using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpOdataDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpOdataDemoEntityFrameworkCoreModule)
        )]
    public class AbpOdataDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpOdataDemoMigrationsDbContext>();
        }
    }
}
