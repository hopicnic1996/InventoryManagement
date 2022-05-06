namespace InventoryManagement.Permissions;

public static class InventoryManagementPermissions
{
    public const string GroupName = "InventoryManagement";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class Units
        {
            public const string Default = GroupName + ".Units";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class UnitsOfGoods
        {
            public const string Default = GroupName + ".UnitsOfGoods";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Goods
        {
            public const string Default = GroupName + ".Goods";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Warehouse
        {
            public const string Default = GroupName + ".Warehouse";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
}
