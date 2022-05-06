using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class WarehouseDto : FullAuditedEntityDto<Guid>
    {
        public Guid? TenantId { get; set; }
        public string WarehouseName { get; set; }

        public string WarehouseAddress { get; set; }

        public string WarehouseNote { get; set; }
    }
}