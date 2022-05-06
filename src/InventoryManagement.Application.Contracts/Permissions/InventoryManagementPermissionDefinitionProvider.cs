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

            var unitsPermission = myGroup.AddPermission(InventoryManagementPermissions.Units.Default, L("Permission:Units"));
            unitsPermission.AddChild(InventoryManagementPermissions.Units.Create, L("Permission:Create"));
            unitsPermission.AddChild(InventoryManagementPermissions.Units.Update, L("Permission:Update"));
            unitsPermission.AddChild(InventoryManagementPermissions.Units.Delete, L("Permission:Delete"));

            var unitsOfGoodsPermission = myGroup.AddPermission(InventoryManagementPermissions.UnitsOfGoods.Default, L("Permission:UnitsOfGoods"));
            unitsOfGoodsPermission.AddChild(InventoryManagementPermissions.UnitsOfGoods.Create, L("Permission:Create"));
            unitsOfGoodsPermission.AddChild(InventoryManagementPermissions.UnitsOfGoods.Update, L("Permission:Update"));
            unitsOfGoodsPermission.AddChild(InventoryManagementPermissions.UnitsOfGoods.Delete, L("Permission:Delete"));

            var goodsPermission = myGroup.AddPermission(InventoryManagementPermissions.Goods.Default, L("Permission:Goods"));
            goodsPermission.AddChild(InventoryManagementPermissions.Goods.Create, L("Permission:Create"));
            goodsPermission.AddChild(InventoryManagementPermissions.Goods.Update, L("Permission:Update"));
            goodsPermission.AddChild(InventoryManagementPermissions.Goods.Delete, L("Permission:Delete"));

            var warehousePermission = myGroup.AddPermission(InventoryManagementPermissions.Warehouse.Default, L("Permission:Warehouse"));
            warehousePermission.AddChild(InventoryManagementPermissions.Warehouse.Create, L("Permission:Create"));
            warehousePermission.AddChild(InventoryManagementPermissions.Warehouse.Update, L("Permission:Update"));
            warehousePermission.AddChild(InventoryManagementPermissions.Warehouse.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<InventoryManagementResource>(name);
    }
}
