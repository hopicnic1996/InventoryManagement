using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Categories.ProductGroup
{
    public class ProductGroupRepository : EfCoreRepository<InventoryManagementDbContext, ProductGroup, Guid>, IProductGroupRepository
    {
        public ProductGroupRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}