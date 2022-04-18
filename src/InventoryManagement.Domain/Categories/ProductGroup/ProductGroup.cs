using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagement.Categories.ProductGroup
{
    public class ProductGroup : AuditedAggregateRoot<Guid>
    {
        public string productGroupName { get; set; }
        public string productGroupDescription { get; set; }

        protected ProductGroup()
        {
        }

        public ProductGroup(
            Guid id,
            string ProductGroupName,
            string ProductGroupDescription
        ) : base(id)
        {
            productGroupName = ProductGroupName;
            productGroupDescription = ProductGroupDescription;
        }
    }
}
