using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class WarehouseRepository : EfCoreRepository<InventoryManagementDbContext, Warehouse, Guid>, IWarehouseRepository
    {
        public WarehouseRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}