using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.WarehouseManager
{
    public interface IUnitsOfGoodsAppService :
        ICrudAppService< 
            UnitsOfGoodsDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateUnitsOfGoodsDto,
            CreateUpdateUnitsOfGoodsDto>
    {
        Task<bool> CheckUnitOfGoodsExist(Guid unitId, Guid goodsId);
        Task DeleteNotInListAsync(string StrUnitId, Guid goodsId);
    }
}