using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Inventories.Inventory.Dtos
{
    [Serializable]
    public class InventoryDto : FullAuditedEntityDto<Guid>
    {
        public string InventoryName { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }
    }
}