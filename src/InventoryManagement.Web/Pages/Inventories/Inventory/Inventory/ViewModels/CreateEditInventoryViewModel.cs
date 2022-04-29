using System;

using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Web.Pages.Inventories.Inventory.Inventory.ViewModels
{
    public class CreateEditInventoryViewModel
    {
        [Display(Name = "InventoryInventoryName")]
        public string InventoryName { get; set; }

        [Display(Name = "InventoryAddress")]
        public string Address { get; set; }

        [Display(Name = "InventoryDescription")]
        public string Description { get; set; }
    }
}