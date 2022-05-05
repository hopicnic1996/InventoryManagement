using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsRepository : EfCoreRepository<InventoryManagementDbContext, Units, Guid>, IUnitsRepository
    {
        public UnitsRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}