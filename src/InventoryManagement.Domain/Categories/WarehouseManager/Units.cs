using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace InventoryManagement.Categories.WarehouseManager
{
    [Table("Unitses")]
    public class Units : FullAuditedEntity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
		[Required]
		[StringLength(UnitsConsts.MaxNameLength, MinimumLength = UnitsConsts.MinNameLength)]
		public virtual string Name { get; set; }

		[StringLength(UnitsConsts.MaxSymbolLength, MinimumLength = UnitsConsts.MinSymbolLength)]
		public virtual string Symbol { get; set; }

		[Required]
		public virtual int Level { get; set; }

		[StringLength(UnitsConsts.MaxNoteLength, MinimumLength = UnitsConsts.MinNoteLength)]
		public virtual string Note { get; set; }
	}
}
