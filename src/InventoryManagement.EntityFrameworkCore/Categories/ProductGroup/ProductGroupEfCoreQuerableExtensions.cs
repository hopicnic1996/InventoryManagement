using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Categories.ProductGroup
{
    public static class ProductGroupEfCoreQueryableExtensions
    {
        public static IQueryable<ProductGroup> IncludeDetails(this IQueryable<ProductGroup> queryable, bool include = true)
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