using System;
using Volo.Abp.Domain.Repositories;

namespace InventoryManagement.Categories.WarehouseManager
{
    public interface IGoodsRepository : IRepository<Goods, Guid>
    {
    }
}