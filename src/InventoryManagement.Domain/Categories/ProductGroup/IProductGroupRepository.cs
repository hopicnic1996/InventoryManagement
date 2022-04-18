using System;
using Volo.Abp.Domain.Repositories;

namespace InventoryManagement.Categories.ProductGroup
{
    public interface IProductGroupRepository : IRepository<ProductGroup, Guid>
    {
    }
}