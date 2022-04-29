using System;
using Volo.Abp.Domain.Repositories;

namespace InventoryManagement.Inventories.Inventory
{
    public interface IInventoryRepository : IRepository<Inventory, Guid>
    {
    }
}