using System;
using InventoryManagement.Permissions;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.TenantManagement;
using System.Threading.Tasks;
using System.Collections.Generic;
using Volo.Abp.Users;
using System.Linq;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class WarehouseAppService : CrudAppService<Warehouse, WarehouseDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateWarehouseDto, CreateUpdateWarehouseDto>,
        IWarehouseAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.Warehouse.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.Warehouse.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.Warehouse.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.Warehouse.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.Warehouse.Delete;

        private readonly IWarehouseRepository _repository;
        private readonly ITenantRepository _tenantRepository;
        private readonly ICurrentUser _currentUser;
        private readonly IDataFilter _dataFilter;

        public WarehouseAppService(IWarehouseRepository repository, ITenantRepository tenantRepository, ICurrentUser currentUser, IDataFilter dataFilter) : base(repository)
        {
            _repository = repository;
            _tenantRepository = tenantRepository;
            _currentUser = currentUser;
            _dataFilter = dataFilter;
        }

        public async Task<PagedResultDto<WarehouseDto>> GetListAllAsync(PagedAndSortedResultRequestDto input)
        {
            IQueryable<Warehouse> queryable = await _repository.GetQueryableAsync();
            if (_currentUser.TenantId == null)
            {
                using (_dataFilter.Disable<IMultiTenant>())
                {
                    queryable = await _repository.GetQueryableAsync();
                    var wareHouses = queryable.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
                    var totalCounts = wareHouses.Count;
                    return new PagedResultDto<WarehouseDto>(
                        totalCounts,
                        ObjectMapper.Map<List<Warehouse>, List<WarehouseDto>>(wareHouses)
                    );
                }
            }
            var wareHouseList = queryable.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
            var totalCount = wareHouseList.Count;
            return new PagedResultDto<WarehouseDto>(
                totalCount,
                ObjectMapper.Map<List<Warehouse>, List<WarehouseDto>>(wareHouseList)
            );
        }

        public async Task<WarehouseDto> GetByIdAsync(Guid id)
        {
            //var wareHouse = await _repository.GetAsync(id);
            //if (_currentUser.TenantId == null)
            //{
            //    using (_dataFilter.Disable<IMultiTenant>())
            //    {
            //        wareHouse = await _repository.GetAsync(id);
            //        return ObjectMapper.Map<Warehouse, WarehouseDto>(wareHouse);
            //    }
            //}
            //return ObjectMapper.Map<Warehouse, WarehouseDto>(wareHouse);
            using (_dataFilter.Disable<IMultiTenant>())
            {
                var wareHouse = await _repository.GetAsync(id);
                return ObjectMapper.Map<Warehouse, WarehouseDto>(wareHouse);
            }
        }

        public async Task<ListResultDto<LookUpDto>> GetTenantLookupAsync()
        {
            var currentUser = _currentUser.TenantId;
            var tenants = await _tenantRepository.GetListAsync();
            var query = tenants.AsQueryable();

            if (_currentUser.TenantId != null)
            {
                tenants = query.Where(x => x.Id == _currentUser.TenantId).ToList();
            }
            else
            {
                tenants = query.ToList();
            }

            return new ListResultDto<LookUpDto>(
                ObjectMapper.Map<List<Tenant>, List<LookUpDto>>(tenants)
            );
        }
    }
}
