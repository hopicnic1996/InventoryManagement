using System.Threading.Tasks;
using InventoryManagement.Permissions;
using InventoryManagement.Localization;
using InventoryManagement.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace InventoryManagement.Web.Menus;

public class InventoryManagementMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<InventoryManagementResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                InventoryManagementMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
            if (await context.IsGrantedAsync(InventoryManagementPermissions.ProductGroup.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(InventoryManagementMenus.ProductGroup, l["Menu:ProductGroup"], "/Categories/ProductGroup/ProductGroup")
                );
            }
            if (await context.IsGrantedAsync(InventoryManagementPermissions.Unit.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(InventoryManagementMenus.Unit, l["Menu:Unit"], "/Categories/Unit/Unit")
                );
            }
            if (await context.IsGrantedAsync(InventoryManagementPermissions.Product.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(InventoryManagementMenus.Product, l["Menu:Product"], "/Products/Product/Product")
                );
            }
    }
}
