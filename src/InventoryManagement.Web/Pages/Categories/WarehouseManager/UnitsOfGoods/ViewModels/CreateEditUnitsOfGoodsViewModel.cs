using System;

using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods.ViewModels
{
    public class CreateEditUnitsOfGoodsViewModel
    {
        [Display(Name = "UnitsOfGoodsUnitId")]
        public Guid UnitId { get; set; }

        [Display(Name = "UnitsOfGoodsUnitName")]
        public string UnitName { get; set; }

        [Display(Name = "UnitsOfGoodsGoodsId")]
        public Guid GoodsId { get; set; }
    }
}