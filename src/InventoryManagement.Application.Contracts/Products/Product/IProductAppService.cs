using System;
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

    }
}