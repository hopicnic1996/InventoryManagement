using System;
using InventoryManagement.Permissions;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsAppService : CrudAppService<Units, UnitsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitsDto, CreateUpdateUnitsDto>,
        IUnitsAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.Units.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.Units.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.Units.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.Units.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.Units.Delete;

        private readonly IUnitsRepository _repository;
        private readonly IUnitsOfGoodsRepository _unitsOfGoodsRepository;

        public UnitsAppService(IUnitsRepository repository, IUnitsOfGoodsRepository unitsOfGoodsRepository) : base(repository)
        {
            _repository = repository;
            _unitsOfGoodsRepository = unitsOfGoodsRepository;
        }

        public async Task<ListResultDto<LookUpDto>> GetUnitLookupByGoodsAsync(Guid GoodsId)
        {
            var units = await _repository.GetListAsync();

            return new ListResultDto<LookUpDto>(
                ObjectMapper.Map<List<Units>, List<LookUpDto>>(units)
            );
        }

        public async Task<ListResultDto<LookUpDto>> GetUnitLookupAsync()
        {
            var units = await _repository.GetListAsync();

            return new ListResultDto<LookUpDto>(
                ObjectMapper.Map<List<Units>, List<LookUpDto>>(units)
            );
        }

        public async Task<PagedResultDto<UnitsDto>> GetNotSelectedUnitAsync(Guid? GoodsId)
        {
            IQueryable<UnitsOfGoods> queryAbleUnitOfGoods = await _unitsOfGoodsRepository.GetQueryableAsync();
            var queryUnitOfGoods = queryAbleUnitOfGoods.Where(x => x.GoodsId == GoodsId).ToList();
            var stringUnitOfGoodsId = "";
            foreach(var unit in queryUnitOfGoods)
            {
                if(stringUnitOfGoodsId != "")
                {
                    stringUnitOfGoodsId += "," + unit.Id;
                }
                else
                {
                    stringUnitOfGoodsId += unit.Id;
                }
            }
            IQueryable<Units> queryAble = await _repository.GetQueryableAsync();
            var query = queryAble.Where(x => !stringUnitOfGoodsId.Contains(x.Id.ToString())).ToList();

            var totalCount = query.Count();

            return new PagedResultDto<UnitsDto>(
                totalCount,
                ObjectMapper.Map<List<Units>, List<UnitsDto>>(query)
            );
        }

        public async Task<PagedResultDto<UnitsDto>> GetUnitForLeftTableAsync()
        {
            var query = await _repository.GetListAsync();

            var totalCount = query.Count();

            return new PagedResultDto<UnitsDto>(
                totalCount,
                ObjectMapper.Map<List<Units>, List<UnitsDto>>(query)
            );
        }
    }
}
