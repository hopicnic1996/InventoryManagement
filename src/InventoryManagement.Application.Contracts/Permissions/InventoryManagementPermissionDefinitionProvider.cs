using InventoryManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.TenantManagement;

namespace InventoryManagement.Permissions;

public class InventoryManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //Disable Tenants Permission
        context.GetPermissionOrNull(TenantManagementPermissions.Tenants.Default).IsEnabled = false;
        context.GetPermissionOrNull(TenantManagementPermissions.Tenants.Create).IsEnabled = false;
        context.GetPermissionOrNull(TenantManagementPermissions.Tenants.Update).IsEnabled = false;
        context.GetPermissionOrNull(TenantManagementPermissions.Tenants.Delete).IsEnabled = false;
        context.GetPermissionOrNull(TenantManagementPermissions.Tenants.ManageFeatures).IsEnabled = false;
        context.GetPermissionOrNull(TenantManagementPermissions.Tenants.ManageConnectionStrings).IsEnabled = false;
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        var myGroup = context.AddGroup(InventoryManagementPermissions.GroupName, L("Permission:InventoryManagement"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(InventoryManagementPermissions.MyPermission1, L("Permission:MyPermission1"));

            var productGroupPermission = myGroup.AddPermission(InventoryManagementPermissions.ProductGroup.Default, L("Permission:ProductGroup"));
            productGroupPermission.AddChild(InventoryManagementPermissions.ProductGroup.Create, L("Permission:Create"));
            productGroupPermission.AddChild(InventoryManagementPermissions.ProductGroup.Update, L("Permission:Update"));
            productGroupPermission.AddChild(InventoryManagementPermissions.ProductGroup.Delete, L("Permission:Delete"));

            var unitPermission = myGroup.AddPermission(InventoryManagementPermissions.Unit.Default, L("Permission:Unit"));
            unitPermission.AddChild(InventoryManagementPermissions.Unit.Create, L("Permission:Create"));
            unitPermission.AddChild(InventoryManagementPermissions.Unit.Update, L("Permission:Update"));
            unitPermission.AddChild(InventoryManagementPermissions.Unit.Delete, L("Permission:Delete"));

            var productPermission = myGroup.AddPermission(InventoryManagementPermissions.Product.Default, L("Permission:Product"));
            productPermission.AddChild(InventoryManagementPermissions.Product.Create, L("Permission:Create"));
            productPermission.AddChild(InventoryManagementPermissions.Product.Update, L("Permission:Update"));
            productPermission.AddChild(InventoryManagementPermissions.Product.Delete, L("Permission:Delete"));

            var inventoryPermission = myGroup.AddPermission(InventoryManagementPermissions.Inventory.Default, L("Permission:Inventory"));
            inventoryPermission.AddChild(InventoryManagementPermissions.Inventory.Create, L("Permission:Create"));
            inventoryPermission.AddChild(InventoryManagementPermissions.Inventory.Update, L("Permission:Update"));
            inventoryPermission.AddChild(InventoryManagementPermissions.Inventory.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InventoryManagementResource>(name);
    }
}
