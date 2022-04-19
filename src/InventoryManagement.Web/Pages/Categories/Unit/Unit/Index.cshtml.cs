using System.Threading.Tasks;

namespace InventoryManagement.Web.Pages.Categories.Unit.Unit
{
    public class IndexModel : InventoryManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
