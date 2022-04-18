using System;

using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup.ViewModels
{
    public class CreateEditProductGroupViewModel
    {
        [Display(Name = "ProductGroupproductGroupName")]
        public string productGroupName { get; set; }

        [Display(Name = "ProductGroupproductGroupDescription")]
        public string productGroupDescription { get; set; }
    }
}