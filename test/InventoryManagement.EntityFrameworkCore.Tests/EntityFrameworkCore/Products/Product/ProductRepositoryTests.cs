using System;
using System.Threading.Tasks;
using InventoryManagement.Products.Product;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Products.Product
{
    public class ProductRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IProductRepository _productRepository;

        public ProductRepositoryTests()
        {
            _productRepository = GetRequiredService<IProductRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
