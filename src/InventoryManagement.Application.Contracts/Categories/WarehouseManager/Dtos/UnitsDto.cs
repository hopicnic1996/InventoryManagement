using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class UnitsDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Symbol { get; set; }

        public int Level { get; set; }

        public string Note { get; set; }
    }
}