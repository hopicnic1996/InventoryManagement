using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.WarehouseManager.Dtos
{
    public class LookUpDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
