using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.WarehouseManager;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Categories.WarehouseManager
{
    public class WarehouseRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IWarehouseRepository _warehouseRepository;

        public WarehouseRepositoryTests()
        {
            _warehouseRepository = GetRequiredService<IWarehouseRepository>();
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
