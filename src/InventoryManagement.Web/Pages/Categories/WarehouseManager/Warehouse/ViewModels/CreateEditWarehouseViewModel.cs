using System;

using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Warehouse.ViewModels
{
    public class CreateEditWarehouseViewModel
    {
        [Display(Name = "TenantName")]
        public Guid? TenantId { get; set; }

        [Required]
        [Display(Name = "WarehouseWarehouseName")]
        public string WarehouseName { get; set; }

        [Required]
        [Display(Name = "WarehouseWarehouseAddress")]
        public string WarehouseAddress { get; set; }

        [Display(Name = "WarehouseWarehouseNote")]
        [TextArea(Rows = 4)]
        public string WarehouseNote { get; set; }
    }
}