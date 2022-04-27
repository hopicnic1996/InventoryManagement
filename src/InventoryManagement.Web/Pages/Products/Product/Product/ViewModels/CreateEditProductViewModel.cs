using System;

using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Web.Pages.Products.Product.Product.ViewModels
{
    public class CreateEditProductViewModel
    {
        [Display(Name = "ProductProductName")]
        public string ProductName { get; set; }

        [Display(Name = "ProductProductGroupId")]
        public Guid? ProductGroupId { get; set; }

        [Display(Name = "ProductProductGroupName")]
        public string ProductGroupName { get; set; }

        [Display(Name = "ProductUnitId")]
        public Guid? UnitId { get; set; }

        [Display(Name = "ProductUnitName")]
        public string UnitName { get; set; }

        [Display(Name = "ProductReferenceUnitId")]
        public Guid? ReferenceUnitId { get; set; }

        [Display(Name = "ProductReferenceUnitName")]
        public string ReferenceUnitName { get; set; }

        [Display(Name = "ProductReferenceUnitQuantity")]
        public int ReferenceUnitQuantity { get; set; }
    }
}