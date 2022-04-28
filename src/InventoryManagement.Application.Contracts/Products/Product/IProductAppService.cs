using System;
using System.Threading.Tasks;
using InventoryManagement.Products.Product.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Products.Product
{
    public interface IProductAppService :
        ICrudAppService< 
            ProductDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateProductDto,
            CreateUpdateProductDto>
    {
        Task<ListResultDto<ProductUnitLookUpDto>> GetProductUnitLookupAsync();
        Task<ListResultDto<ProductUnitLookUpDto>> GetReferentceProductUnitLookupAsync(Guid unitId);
        Task<ListResultDto<ProductGroupLookUpDto>> GetProductGroupLookupAsync();
    }
}