using System;
using Volo.Abp.Application.Dtos;

namespace InventoryManagement.Categories.ProductGroup.Dtos
{
    [Serializable]
    public class ProductGroupDto : AuditedEntityDto<Guid>
    {
        public string productGroupName { get; set; }

        public string productGroupDescription { get; set; }
    }
}