using System.Threading.Tasks;

namespace InventoryManagement.Web.Pages.Categories.ProductGroup.ProductGroup
{
    public class IndexModel : InventoryManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}