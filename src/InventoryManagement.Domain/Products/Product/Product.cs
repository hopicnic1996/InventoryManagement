using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagement.Products.Product
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string ProductName { get; set; }
        public Guid? ProductGroupId { get; set; }
        public string ProductGroupName { get; set; }
        public Guid? UnitId { get; set; }
        public string UnitName { get; set; }
        public Guid? ReferenceUnitId { get; set; }
        public string ReferenceUnitName { get; set; }
        public int ReferenceUnitQuantity { get; set; }

        protected Product()
        {
        }

        public Product(
            Guid id,
            string productName,
            Guid? productGroupId,
            string productGroupName,
            Guid? unitId,
            string unitName,
            Guid? referenceUnitId,
            string referenceUnitName,
            int referenceUnitQuantity
        ) : base(id)
        {
            ProductName = productName;
            ProductGroupId = productGroupId;
            ProductGroupName = productGroupName;
            UnitId = unitId;
            UnitName = unitName;
            ReferenceUnitId = referenceUnitId;
            ReferenceUnitName = referenceUnitName;
            ReferenceUnitQuantity = referenceUnitQuantity;
        }
    }
}
