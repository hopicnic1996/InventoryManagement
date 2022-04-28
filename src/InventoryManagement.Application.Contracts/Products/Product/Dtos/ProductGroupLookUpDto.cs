using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Products.Product.Dtos
{
    public class ProductGroupLookUpDto : EntityDto<Guid>
    {
        public string ProductGroupName { get; set; }
    }
}
