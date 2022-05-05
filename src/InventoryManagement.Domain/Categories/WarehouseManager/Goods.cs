using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace InventoryManagement.Categories.WarehouseManager
{
	[Table("Goodses")]
	public class Goods : FullAuditedEntity<Guid>
	{
		[Required]
		[StringLength(GoodsConsts.MaxGoodsNameLength, MinimumLength = GoodsConsts.MinGoodsNameLength)]
		public virtual string GoodsName { get; set; }

		public virtual string GoodsCode { get; set; }

		[StringLength(GoodsConsts.MaxNoteLength, MinimumLength = GoodsConsts.MinNoteLength)]
		public virtual string Note { get; set; }

        protected Goods()
        {
        }

        public Goods(
            Guid id,
            string goodsName,
            string goodsCode,
            string note
        ) : base(id)
        {
            GoodsName = goodsName;
            GoodsCode = goodsCode;
            Note = note;
        }
	}
}
