using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagement.Categories.WarehouseManager
{
    public class WarehouseAppServiceTests : InventoryManagementApplicationTestBase
    {
        private readonly IWarehouseAppService _warehouseAppService;

        public WarehouseAppServiceTests()
        {
            _warehouseAppService = GetRequiredService<IWarehouseAppService>();
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
