using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.Unit.Dtos
{
    [Serializable]
    public class UnitDto : FullAuditedEntityDto<Guid>
    {
        public string UnitName { get; set; }
    }
}