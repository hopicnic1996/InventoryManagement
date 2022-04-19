using System;
using System.ComponentModel;
namespace InventoryManagement.Categories.Unit.Dtos
{
    [Serializable]
    public class CreateUpdateUnitDto
    {
        public string UnitName { get; set; }
    }
}