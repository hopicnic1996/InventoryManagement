using InventoryManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace InventoryManagement.Permissions;

public class InventoryManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(InventoryManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(InventoryManagementPermissions.MyPermission1, L("Permission:MyPermission1"));

            var productGroupPermission = myGroup.AddPermission(InventoryManagementPermissions.ProductGroup.Default, L("Permission:ProductGroup"));
            productGroupPermission.AddChild(InventoryManagementPermissions.ProductGroup.Create, L("Permission:Create"));
            productGroupPermission.AddChild(InventoryManagementPermissions.ProductGroup.Update, L("Permission:Update"));
            productGroupPermission.AddChild(InventoryManagementPermissions.ProductGroup.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InventoryManagementResource>(name);
    }
}
