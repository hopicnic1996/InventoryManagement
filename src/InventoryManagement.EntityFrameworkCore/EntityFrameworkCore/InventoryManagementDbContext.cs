using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using InventoryManagement.Categories.ProductGroup;
using Volo.Abp.EntityFrameworkCore.Modeling;
using InventoryManagement.Categories.Unit;
using InventoryManagement.Products.Product;
using InventoryManagement.Inventories.Inventory;

namespace InventoryManagement.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class InventoryManagementDbContext :
    AbpDbContext<InventoryManagementDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

    public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(InventoryManagementConsts.DbTablePrefix + "YourEntities", InventoryManagementConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});


            builder.Entity<ProductGroup>(b =>
            {
                b.ToTable(InventoryManagementConsts.DbTablePrefix + "ProductGroups", InventoryManagementConsts.DbSchema);
                b.ConfigureByConvention();
                b.Property(x => x.productGroupName).IsRequired();
                b.HasIndex(x => x.productGroupName).IsUnique();
                

                /* Configure more properties here */
            });


            builder.Entity<Unit>(b =>
            {
                b.ToTable(InventoryManagementConsts.DbTablePrefix + "Units", InventoryManagementConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Product>(b =>
            {
                b.ToTable(InventoryManagementConsts.DbTablePrefix + "Products", InventoryManagementConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });


            builder.Entity<Inventory>(b =>
            {
                b.ToTable(InventoryManagementConsts.DbTablePrefix + "Inventories", InventoryManagementConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
    }
}
