using System;
using System.Threading.Tasks;
using InventoryManagement.Categories.WarehouseManager;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace InventoryManagement.EntityFrameworkCore.Categories.WarehouseManager
{
    public class GoodsRepositoryTests : InventoryManagementEntityFrameworkCoreTestBase
    {
        private readonly IGoodsRepository _goodsRepository;

        public GoodsRepositoryTests()
        {
            _goodsRepository = GetRequiredService<IGoodsRepository>();
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
