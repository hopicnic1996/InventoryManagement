using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class GoodsRepository : EfCoreRepository<InventoryManagementDbContext, Goods, Guid>, IGoodsRepository
    {
        public GoodsRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}