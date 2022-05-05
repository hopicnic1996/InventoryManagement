using System;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.WarehouseManager
{
    public interface IGoodsAppService :
        ICrudAppService< 
            GoodsDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateGoodsDto,
            CreateUpdateGoodsDto>
    {

    }
}