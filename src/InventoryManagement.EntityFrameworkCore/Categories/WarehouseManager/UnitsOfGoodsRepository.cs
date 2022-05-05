using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsOfGoodsRepository : EfCoreRepository<InventoryManagementDbContext, UnitsOfGoods, Guid>, IUnitsOfGoodsRepository
    {
        public UnitsOfGoodsRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}