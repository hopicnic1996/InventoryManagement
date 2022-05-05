using Microsoft.AspNetCore.Mvc;
using System;

using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Goods.ViewModels
{
    public class CreateEditGoodsViewModel
    {
        [Display(Name = "GoodsGoodsName")]
        public string GoodsName { get; set; }

        [Display(Name = "GoodsGoodsCode")]
        [HiddenInput]
        public string GoodsCode { get; set; }

        [Display(Name = "GoodsNote")]
        [TextArea(Rows = 4)]
        public string Note { get; set; }

        //[HiddenInput]
        public string UnitOfGood { get; set; }
    }
}