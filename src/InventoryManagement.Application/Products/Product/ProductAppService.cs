using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryManagement.Categories.ProductGroup;
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
        private readonly IProductGroupRepository _productGroupRepository;
        
        public ProductAppService(IProductRepository repository, IUnitRepository unitRepository, IProductGroupRepository productGroupRepository) : base(repository)
        {
            _repository = repository;
            _unitRepository = unitRepository;
            _productGroupRepository = productGroupRepository;
        }

        public async Task<ListResultDto<ProductUnitLookUpDto>> GetProductUnitLookupAsync()
        {
            var units = await _unitRepository.GetListAsync();

            return new ListResultDto<ProductUnitLookUpDto>(
                ObjectMapper.Map<List<Unit>, List<ProductUnitLookUpDto>>(units)
            );
        }

        public async Task<ListResultDto<ProductUnitLookUpDto>> GetReferentceProductUnitLookupAsync(Guid unitId)
        {
            IQueryable<Unit> query = await _unitRepository.GetQueryableAsync();
            var units = query.Where(x => x.Id != unitId).ToList();

            return new ListResultDto<ProductUnitLookUpDto>(
                ObjectMapper.Map<List<Unit>, List<ProductUnitLookUpDto>>(units)
            );
        }

        public async Task<ListResultDto<ProductGroupLookUpDto>> GetProductGroupLookupAsync()
        {
            var productGroup = await _productGroupRepository.GetListAsync();

            return new ListResultDto<ProductGroupLookUpDto>(
                ObjectMapper.Map<List<ProductGroup>, List<ProductGroupLookUpDto>>(productGroup)
            );
        }

    }
}
