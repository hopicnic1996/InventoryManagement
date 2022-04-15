using InventoryManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace InventoryManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class InventoryManagementPageModel : AbpPageModel
{
    protected InventoryManagementPageModel()
    {
        LocalizationResourceType = typeof(InventoryManagementResource);
    }
}
