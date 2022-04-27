using System;
using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace InventoryManagement.Products.Product
{
    public class ProductRepository : EfCoreRepository<InventoryManagementDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<InventoryManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}