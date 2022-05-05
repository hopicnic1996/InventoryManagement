using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    public class GetCreateUpdateGoodsInputDto
    {
        public string GoodsName { get; set; }

        public string GoodsCode { get; set; }

        public string Note { get; set; }

        public string UnitOfGood { get; set; }
    }
}
