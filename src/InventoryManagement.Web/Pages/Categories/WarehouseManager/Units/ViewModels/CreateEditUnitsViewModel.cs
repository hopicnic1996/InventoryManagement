using System;

using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.Units.ViewModels
{
    public class CreateEditUnitsViewModel
    {
        [Display(Name = "UnitsName")]
        public string Name { get; set; }

        [Display(Name = "UnitsSymbol")]
        public string Symbol { get; set; }

        [Display(Name = "UnitsLevel")]
        public int Level { get; set; }

        [Display(Name = "UnitsNote")]
        public string Note { get; set; }
    }
}