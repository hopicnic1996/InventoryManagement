using System;
using System.ComponentModel;
namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class CreateUpdateGoodsDto
    {
        public string GoodsName { get; set; }

        public string GoodsCode { get; set; }

        public string Note { get; set; }
    }
}