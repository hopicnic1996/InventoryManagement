using InventoryManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace InventoryManagement;

[DependsOn(
    typeof(InventoryManagementEntityFrameworkCoreTestModule)
    )]
public class InventoryManagementDomainTestModule : AbpModule
{

}
