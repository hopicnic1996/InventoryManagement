using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Categories.WarehouseManager
{
    public static class UnitsEfCoreQueryableExtensions
    {
        public static IQueryable<Units> IncludeDetails(this IQueryable<Units> queryable, bool include = true)
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