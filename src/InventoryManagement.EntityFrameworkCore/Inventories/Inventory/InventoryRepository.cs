using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Inventories.Inventory
{
    public class InventoryRepository : EfCoreRepository<InventoryManagementDbContext, Inventory, Guid>, IInventoryRepository
    {
        public InventoryRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}