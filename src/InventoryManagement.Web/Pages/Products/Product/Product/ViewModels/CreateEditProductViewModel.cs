using Microsoft.AspNetCore.Mvc;
using System;

using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Web.Pages.Products.Product.Product.ViewModels
{
    public class CreateEditProductViewModel
    {
        [Display(Name = "ProductProductName")]
        public string ProductName { get; set; }

        [Required]
        //[Display(Name = "ProductProductGroupId")]
        [Display(Name = "ProductProductGroupName")]
        public Guid ProductGroupId { get; set; }

        [Display(Name = "ProductProductGroupName")]
        public string ProductGroupName { get; set; }

        [Required]
        //[Display(Name = "ProductUnitId")]
        [Display(Name = "ProductUnitName")]
        public Guid UnitId { get; set; }

        [Display(Name = "ProductUnitName")]
        public string UnitName { get; set; }

        //[Display(Name = "ProductReferenceUnitId")]
        [Display(Name = "ProductReferenceUnitName")]
        public Guid? ReferenceUnitId { get; set; }

        [Display(Name = "ProductReferenceUnitName")]
        public string ReferenceUnitName { get; set; }

        [Display(Name = "ProductReferenceUnitQuantity")]
        public int? ReferenceUnitQuantity { get; set; }
    }
}