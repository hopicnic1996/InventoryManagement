using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.WarehouseManager;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Categories.WarehouseManager
{
    public class UnitsRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IUnitsRepository _unitsRepository;

        public UnitsRepositoryTests()
        {
            _unitsRepository = GetRequiredService<IUnitsRepository>();
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
