using System;
using InventoryManagement.Categories.Unit.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace InventoryManagement.Categories.Unit
{
    public interface IUnitAppService :
        ICrudAppService< 
            UnitDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateUnitDto,
            CreateUpdateUnitDto>
    {

    }
}