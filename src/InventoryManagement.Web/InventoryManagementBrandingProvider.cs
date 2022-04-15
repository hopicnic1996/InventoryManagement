using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace InventoryManagement.Web;

[Dependency(ReplaceServices = true)]
public class InventoryManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Inventory Management";
}
