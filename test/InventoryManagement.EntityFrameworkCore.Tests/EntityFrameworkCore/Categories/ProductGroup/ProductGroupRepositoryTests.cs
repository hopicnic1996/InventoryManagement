using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.ProductGroup;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Categories.ProductGroup
{
    public class ProductGroupRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IProductGroupRepository _productGroupRepository;

        public ProductGroupRepositoryTests()
        {
            _productGroupRepository = GetRequiredService<IProductGroupRepository>();
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
