using System;
using System.ComponentModel;
namespace InventoryManagement.Categories.ProductGroup.Dtos
{
    [Serializable]
    public class CreateUpdateProductGroupDto
    {
        public string productGroupName { get; set; }

        public string productGroupDescription { get; set; }
    }
}