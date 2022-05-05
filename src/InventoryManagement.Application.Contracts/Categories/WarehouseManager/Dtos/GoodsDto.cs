using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    [Serializable]
    public class GoodsDto : FullAuditedEntityDto<Guid>
    {
        public string GoodsName { get; set; }

        public string GoodsCode { get; set; }

        public string Note { get; set; }
    }
}