using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Products.Product.Dtos
{
    public class ProductUnitLookUpDto : EntityDto<Guid>
    {
        public string UnitName { get; set; }
    }
}
