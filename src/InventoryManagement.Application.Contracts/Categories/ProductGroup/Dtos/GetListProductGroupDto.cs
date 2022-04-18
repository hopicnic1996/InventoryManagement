using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.ProductGroup.Dtos
{
    public class GetListProductGroupDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
