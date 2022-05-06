using System;
using System.ComponentModel;
namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class CreateUpdateWarehouseDto
    {
        public Guid? TenantId { get; set; }
        public string WarehouseName { get; set; }

        public string WarehouseAddress { get; set; }

        public string WarehouseNote { get; set; }
    }
}