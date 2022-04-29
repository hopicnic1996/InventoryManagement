using System;
using System.Threading.Tasks;
using InventoryManagement.Inventories.Inventory;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Inventories.Inventory
{
    public class InventoryRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryRepositoryTests()
        {
            _inventoryRepository = GetRequiredService<IInventoryRepository>();
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
