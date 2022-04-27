using System;
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
        
        public ProductAppService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
