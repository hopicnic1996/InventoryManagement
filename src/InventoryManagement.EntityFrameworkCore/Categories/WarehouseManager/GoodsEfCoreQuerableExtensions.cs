using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Categories.WarehouseManager
{
    public static class GoodsEfCoreQueryableExtensions
    {
        public static IQueryable<Goods> IncludeDetails(this IQueryable<Goods> queryable, bool include = true)
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