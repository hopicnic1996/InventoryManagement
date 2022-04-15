using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace InventoryManagement.Pages;

public class Index_Tests : InventoryManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
