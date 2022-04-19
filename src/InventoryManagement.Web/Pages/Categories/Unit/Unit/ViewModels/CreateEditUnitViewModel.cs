using System;

using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Web.Pages.Categories.Unit.Unit.ViewModels
{
    public class CreateEditUnitViewModel
    {
        [Display(Name = "UnitUnitName")]
        public string UnitName { get; set; }
    }
}