using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.WarehouseManager;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Categories.WarehouseManager
{
    public class UnitsOfGoodsRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IUnitsOfGoodsRepository _unitsOfGoodsRepository;

        public UnitsOfGoodsRepositoryTests()
        {
            _unitsOfGoodsRepository = GetRequiredService<IUnitsOfGoodsRepository>();
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
