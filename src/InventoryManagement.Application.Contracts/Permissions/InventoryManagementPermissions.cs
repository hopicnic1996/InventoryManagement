namespace InventoryManagement.Permissions;

public static class InventoryManagementPermissions
{
    public const string GroupName = "Inventory Management";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

        public class ProductGroup
        {
            public const string Default = GroupName + ".ProductGroup";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Unit
        {
            public const string Default = GroupName + ".Unit";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Product
        {
            public const string Default = GroupName + ".Product";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class Inventory
        {
            public const string Default = GroupName + ".Inventory";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
}
