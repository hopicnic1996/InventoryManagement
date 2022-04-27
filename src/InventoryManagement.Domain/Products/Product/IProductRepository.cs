using System;
using Volo.Abp.Domain.Repositories;

namespace InventoryManagement.Products.Product
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}