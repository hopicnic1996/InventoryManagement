using System;
using Volo.Abp.Domain.Repositories;

namespace InventoryManagement.Categories.WarehouseManager
{
    public interface IUnitsRepository : IRepository<Units, Guid>
    {
    }
}