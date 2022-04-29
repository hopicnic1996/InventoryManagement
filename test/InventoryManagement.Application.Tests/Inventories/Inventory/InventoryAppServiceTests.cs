using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagement.Inventories.Inventory
{
    public class InventoryAppServiceTests : InventoryManagementApplicationTestBase
    {
        private readonly IInventoryAppService _inventoryAppService;

        public InventoryAppServiceTests()
        {
            _inventoryAppService = GetRequiredService<IInventoryAppService>();
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
