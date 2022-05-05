using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class UnitsAppServiceTests : InventoryManagementApplicationTestBase
    {
        private readonly IUnitsAppService _unitsAppService;

        public UnitsAppServiceTests()
        {
            _unitsAppService = GetRequiredService<IUnitsAppService>();
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
