using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class UnitsOfGoodsDto : EntityDto<Guid>
    {
        public Guid UnitId { get; set; }

        public string UnitName { get; set; }

        public Guid GoodsId { get; set; }
    }
}