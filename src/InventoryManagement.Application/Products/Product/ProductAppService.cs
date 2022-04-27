using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InventoryManagement.Categories.Unit;
using InventoryManagement.Permissions;
using InventoryManagement.Products.Product.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Products.Product
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto, CreateUpdateProductDto>,
        IProductAppService
    {
        protected override string GetPolicyName { get; set; } = InventoryManagementPermissions.Product.Default;
        protected override string GetListPolicyName { get; set; } = InventoryManagementPermissions.Product.Default;
        protected override string CreatePolicyName { get; set; } = InventoryManagementPermissions.Product.Create;
        protected override string UpdatePolicyName { get; set; } = InventoryManagementPermissions.Product.Update;
        protected override string DeletePolicyName { get; set; } = InventoryManagementPermissions.Product.Delete;

        private readonly IProductRepository _repository;
        private readonly IUnitRepository _unitRepository;
        
        public ProductAppService(IProductRepository repository, IUnitRepository unitRepository) : base(repository)
        {
            _repository = repository;
            _unitRepository = unitRepository;
        }

        public async Task<ListResultDto<ProductUnitLookUpDto>> GetUnitLookupAsync()
        {
            var units = await _unitRepository.GetListAsync();

            return new ListResultDto<ProductUnitLookUpDto>(
                ObjectMapper.Map<List<Unit>, List<ProductUnitLookUpDto>>(units)
            );
        }

    }
}
