using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class GoodsAppServiceTests : InventoryManagementApplicationTestBase
    {
        private readonly IGoodsAppService _goodsAppService;

        public GoodsAppServiceTests()
        {
            _goodsAppService = GetRequiredService<IGoodsAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
