using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.WarehouseManager
{
    public interface IUnitsAppService :
        ICrudAppService< 
            UnitsDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateUnitsDto,
            CreateUpdateUnitsDto>
    {
        Task<PagedResultDto<UnitsDto>> GetNotSelectedUnitAsync(Guid? GoodsId);
        Task<PagedResultDto<UnitsDto>> GetUnitForLeftTableAsync();
    }
}