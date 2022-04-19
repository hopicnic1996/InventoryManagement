using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagement.Categories.Unit
{
    public class UnitAppServiceTests : InventoryManagementApplicationTestBase
    {
        private readonly IUnitAppService _unitAppService;

        public UnitAppServiceTests()
        {
            _unitAppService = GetRequiredService<IUnitAppService>();
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
