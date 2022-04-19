using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagement.Categories.Unit
{
    public class Unit : FullAuditedAggregateRoot<Guid>
    {
        public string UnitName { get; set; }

        protected Unit()
        {
        }

        public Unit(
            Guid id,
            string unitName
        ) : base(id)
        {
            UnitName = unitName;
        }
    }
}
