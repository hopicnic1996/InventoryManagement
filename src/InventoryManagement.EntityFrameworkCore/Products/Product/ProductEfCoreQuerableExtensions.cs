using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Products.Product
{
    public static class ProductEfCoreQueryableExtensions
    {
        public static IQueryable<Product> IncludeDetails(this IQueryable<Product> queryable, bool include = true)
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