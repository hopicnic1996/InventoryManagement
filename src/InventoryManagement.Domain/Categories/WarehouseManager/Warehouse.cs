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
    [Table("Warehouses")]
    public class Warehouse : FullAuditedEntity<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        [Required]
        [StringLength(WarehouseConsts.MaxWarehouseNameLength, MinimumLength = WarehouseConsts.MinWarehouseNameLength)]
        public virtual string WarehouseName { get; set; }

        [StringLength(WarehouseConsts.MaxWarehouseAddressLength)]
        public virtual string WarehouseAddress { get; set; }

        [StringLength(WarehouseConsts.MaxWarehouseNoteLength)]
        public virtual string WarehouseNote { get; set; }

        protected Warehouse()
        {
        }

        public Warehouse(
            Guid id,
            Guid? tenantId,
            string warehouseName,
            string warehouseAddress,
            string warehouseNote
        ) : base(id)
        {
            TenantId = tenantId;
            WarehouseName = warehouseName;
            WarehouseAddress = warehouseAddress;
            WarehouseNote = warehouseNote;
        }
    }
}
