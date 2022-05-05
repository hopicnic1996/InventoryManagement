using System;
using System.ComponentModel;
namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class CreateUpdateUnitsOfGoodsDto
    {
        public Guid UnitId { get; set; }

        public string UnitName { get; set; }

        public Guid GoodsId { get; set; }
    }
}