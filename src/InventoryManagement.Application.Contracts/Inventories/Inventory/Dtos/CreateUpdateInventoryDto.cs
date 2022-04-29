using System;
using System.ComponentModel;
namespace InventoryManagement.Inventories.Inventory.Dtos
{
    [Serializable]
    public class CreateUpdateInventoryDto
    {
        public string InventoryName { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }
    }
}