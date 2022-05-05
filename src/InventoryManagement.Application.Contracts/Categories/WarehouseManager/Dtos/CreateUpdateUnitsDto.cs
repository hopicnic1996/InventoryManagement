using System;
using System.ComponentModel;
namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class CreateUpdateUnitsDto
    {
        public string Name { get; set; }

        public string Symbol { get; set; }

        public int Level { get; set; }

        public string Note { get; set; }
    }
}