using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.WarehouseManager.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.WarehouseManager
{
    public interface IWarehouseAppService :
        ICrudAppService< 
            WarehouseDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateWarehouseDto,
            CreateUpdateWarehouseDto>
    {
        Task<ListResultDto<LookUpDto>> GetTenantLookupAsync();
        Task<WarehouseDto> GetByIdAsync(Guid id);
        Task<PagedResultDto<WarehouseDto>> GetListAllAsync(PagedAndSortedResultRequestDto input);
    }
}