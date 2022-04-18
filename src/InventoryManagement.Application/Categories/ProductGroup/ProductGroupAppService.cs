using System;
using InventoryManagement.Permissions;
using InventoryManagement.Categories.ProductGroup.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using Volo.Abp;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace InventoryManagement.Categories.ProductGroup
{
    [Authorize(InventoryManagementPermissions.ProductGroup.Default)]
    public class ProductGroupAppService : InventoryManagementAppService,
        IProductGroupAppService
    {
        //protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.ProductGroup.Default;
        //protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.ProductGroup.Default;
        //protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.ProductGroup.Create;
        //protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.ProductGroup.Update;
        //protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.ProductGroup.Delete;

        private readonly IProductGroupRepository _repository;
        
        public ProductGroupAppService(IProductGroupRepository repository)
        {
            _repository = repository;
        }

        public async Task<PagedResultDto<ProductGroupDto>> GetListAsync(GetListProductGroupDto input)
        {
            //var productGroup = await _repository.GetPagedListAsync(input.SkipCount,input.MaxResultCount,input.Sorting);
            IQueryable<ProductGroup> queryable = await _repository.GetQueryableAsync();
            var query = queryable.Where(x => input.Filter != null ? x.productGroupName.Contains(input.Filter) : true);
            //queryable.Where(x => input.Filter != "" ? x.productGroupName.Contains(input.Filter) : true).Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
            switch (input.Sorting)
            {
                case "productGroupName asc":
                    query = query.OrderBy(x => x.productGroupName);
                    break;
                case "productGroupName desc":
                    query = query.OrderByDescending(x => x.productGroupName);
                    break;
                case "productGroupDescription asc":
                    query = query.OrderBy(x => x.productGroupDescription);
                    break;
                case "productGroupDescription desc":
                    query = query.OrderByDescending(x => x.productGroupDescription);
                    break;
                default:break;
            }
            var productGroup = query.Skip(input.SkipCount).Take(input.MaxResultCount).ToList();
            var totalCount = query.ToList().Count;
            return new PagedResultDto<ProductGroupDto>(
                totalCount,
                ObjectMapper.Map<List<ProductGroup>, List<ProductGroupDto>>(productGroup)
            );
        }

        public async Task<ProductGroupDto> GetAsync(Guid id)
        {
            var productGroup = await _repository.GetAsync(id);
            return ObjectMapper.Map<ProductGroup, ProductGroupDto>(productGroup);
        }

        [Authorize(InventoryManagementPermissions.ProductGroup.Create)]
        public async Task<ProductGroupDto> CreateAsync(CreateUpdateProductGroupDto input)
        {
            var productGroupList = _repository.GetListAsync().Result;
            if (productGroupList.Exists(x => x.productGroupName.Contains(input.productGroupName)))
            {
                throw new UserFriendlyException("Name already exist!");
            }
            ProductGroup productGroup = new ProductGroup(GuidGenerator.Create(), input.productGroupName, input.productGroupDescription);
            await _repository.InsertAsync(productGroup);
            return ObjectMapper.Map<ProductGroup, ProductGroupDto>(productGroup);
        }

        [Authorize(InventoryManagementPermissions.ProductGroup.Update)]
        public async Task UpdateAsync(Guid id, CreateUpdateProductGroupDto input)
        {
            var productGroup = await _repository.GetAsync(id);
            var productGroupList = _repository.GetListAsync().Result;
            if (productGroupList.Exists(x => x.productGroupName.Contains(input.productGroupName))){
                throw new UserFriendlyException("Name already exist!");
            }

            productGroup.productGroupName = input.productGroupName;
            productGroup.productGroupDescription = input.productGroupDescription;

            await _repository.UpdateAsync(productGroup);
        }

        [Authorize(InventoryManagementPermissions.ProductGroup.Delete)]
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
