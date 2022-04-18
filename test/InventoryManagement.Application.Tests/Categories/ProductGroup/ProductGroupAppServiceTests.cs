using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace InventoryManagement.Categories.ProductGroup
{
    public class ProductGroupAppServiceTests : InventoryManagementApplicationTestBase
    {
        private readonly IProductGroupAppService _productGroupAppService;

        public ProductGroupAppServiceTests()
        {
            _productGroupAppService = GetRequiredService<IProductGroupAppService>();
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
