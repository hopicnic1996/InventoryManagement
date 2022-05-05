using System.Threading.Tasks;

namespace InventoryManagement.Web.Pages.Categories.WarehouseManager.UnitsOfGoods
{
    public class IndexModel : InventoryManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
