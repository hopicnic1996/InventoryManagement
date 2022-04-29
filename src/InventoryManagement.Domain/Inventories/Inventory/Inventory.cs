using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagement.Inventories.Inventory
{
    public class Inventory : FullAuditedAggregateRoot<Guid>
    {
        public string InventoryName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        protected Inventory()
        {
        }

        public Inventory(
            Guid id,
            string inventoryName,
            string address,
            string description
        ) : base(id)
        {
            InventoryName = inventoryName;
            Address = address;
            Description = description;
        }
    }
}
