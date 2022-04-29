using System;
using InventoryManagement.Inventories.Inventory.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Inventories.Inventory
{
    public interface IInventoryAppService :
        ICrudAppService< 
            InventoryDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateInventoryDto,
            CreateUpdateInventoryDto>
    {

    }
}