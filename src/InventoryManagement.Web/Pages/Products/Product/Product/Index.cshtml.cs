using System.Threading.Tasks;

namespace InventoryManagement.Web.Pages.Products.Product.Product
{
    public class IndexModel : InventoryManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
