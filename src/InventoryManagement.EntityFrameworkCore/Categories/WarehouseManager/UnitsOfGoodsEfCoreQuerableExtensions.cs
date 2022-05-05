using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Categories.WarehouseManager
{
    public static class UnitsOfGoodsEfCoreQueryableExtensions
    {
        public static IQueryable<UnitsOfGoods> IncludeDetails(this IQueryable<UnitsOfGoods> queryable, bool include = true)
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