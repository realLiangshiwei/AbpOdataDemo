using Qc.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Qc.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(QcEntityFrameworkCoreDbMigrationsModule),
        typeof(QcApplicationContractsModule)
        )]
    public class QcDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
