using System;
using Volo.Abp.Domain.Repositories;

namespace InventoryManagement.Categories.Unit
{
    public interface IUnitRepository : IRepository<Unit, Guid>
    {
    }
}