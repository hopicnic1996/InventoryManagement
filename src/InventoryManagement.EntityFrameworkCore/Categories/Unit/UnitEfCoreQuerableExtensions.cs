using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Categories.Unit
{
    public static class UnitEfCoreQueryableExtensions
    {
        public static IQueryable<Unit> IncludeDetails(this IQueryable<Unit> queryable, bool include = true)
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