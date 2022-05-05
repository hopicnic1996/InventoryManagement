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
            if (await context.IsGrantedAsync(InventoryManagementPermissions.Units.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(InventoryManagementMenus.Units, l["Menu:Units"], "/Categories/WarehouseManager/Units")
                );
            }
            if (await context.IsGrantedAsync(InventoryManagementPermissions.UnitsOfGoods.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(InventoryManagementMenus.UnitsOfGoods, l["Menu:UnitsOfGoods"], "/Categories/WarehouseManager/UnitsOfGoods")
                );
            }
            if (await context.IsGrantedAsync(InventoryManagementPermissions.Goods.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(InventoryManagementMenus.Goods, l["Menu:Goods"], "/Categories/WarehouseManager/Goods")
                );
            }
    }
}
