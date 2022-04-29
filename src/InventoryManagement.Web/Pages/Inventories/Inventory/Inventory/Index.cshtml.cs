using System.Threading.Tasks;

namespace InventoryManagement.Web.Pages.Inventories.Inventory.Inventory
{
    public class IndexModel : InventoryManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
