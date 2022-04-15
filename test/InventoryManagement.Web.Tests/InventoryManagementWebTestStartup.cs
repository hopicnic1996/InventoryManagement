using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace InventoryManagement;

public class InventoryManagementWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<InventoryManagementWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
