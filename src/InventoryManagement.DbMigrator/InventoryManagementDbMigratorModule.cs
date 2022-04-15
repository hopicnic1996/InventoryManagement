using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace InventoryManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InventoryManagementEntityFrameworkCoreModule),
    typeof(InventoryManagementApplicationContractsModule)
    )]
public class InventoryManagementDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
