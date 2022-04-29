using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Inventories.Inventory
{
    public static class InventoryEfCoreQueryableExtensions
    {
        public static IQueryable<Inventory> IncludeDetails(this IQueryable<Inventory> queryable, bool include = true)
        {
            if (!include)
            {
                return queryable;
            }

            return queryable
                // .Include(x => x.xxx) // TODO: AbpHelper generated
                ;
        }
    }
}