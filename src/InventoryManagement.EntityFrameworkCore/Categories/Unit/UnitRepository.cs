using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Categories.Unit
{
    public class UnitRepository : EfCoreRepository<InventoryManagementDbContext, Unit, Guid>, IUnitRepository
    {
        public UnitRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}