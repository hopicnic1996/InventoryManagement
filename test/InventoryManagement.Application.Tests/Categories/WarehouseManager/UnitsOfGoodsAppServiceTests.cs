using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsOfGoodsAppServiceTests : InventoryManagementApplicationTestBase
    {
        private readonly IUnitsOfGoodsAppService _unitsOfGoodsAppService;

        public UnitsOfGoodsAppServiceTests()
        {
            _unitsOfGoodsAppService = GetRequiredService<IUnitsOfGoodsAppService>();
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
