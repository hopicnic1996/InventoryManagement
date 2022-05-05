using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsOfGoods : Entity<Guid>
    {
        public virtual Guid UnitId { get; set; }
        public virtual string UnitName { get; set; }
        public virtual Guid GoodsId { get; set; }

        protected UnitsOfGoods()
        {
        }

        public UnitsOfGoods(
            Guid id,
            Guid unitId,
            string unitName,
            Guid goodsId
        ) : base(id)
        {
            UnitId = unitId;
            UnitName = unitName;
            GoodsId = goodsId;
        }
    }
}
