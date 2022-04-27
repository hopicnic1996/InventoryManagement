using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Products.Product.Dtos
{
    [Serializable]
    public class ProductDto : FullAuditedEntityDto<Guid>
    {
        public string ProductName { get; set; }

        public Guid? ProductGroupId { get; set; }

        public string ProductGroupName { get; set; }

        public Guid? UnitId { get; set; }

        public string UnitName { get; set; }

        public Guid? ReferenceUnitId { get; set; }

        public string ReferenceUnitName { get; set; }

        public int ReferenceUnitQuantity { get; set; }
    }
}