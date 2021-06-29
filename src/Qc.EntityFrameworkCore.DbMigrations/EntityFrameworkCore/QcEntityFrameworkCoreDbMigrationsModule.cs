using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Qc.EntityFrameworkCore
{
    [DependsOn(
        typeof(QcEntityFrameworkCoreModule)
        )]
    public class QcEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<QcMigrationsDbContext>();
        }
    }
}
