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
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InventoryManagementResource>(name);
    }
}
