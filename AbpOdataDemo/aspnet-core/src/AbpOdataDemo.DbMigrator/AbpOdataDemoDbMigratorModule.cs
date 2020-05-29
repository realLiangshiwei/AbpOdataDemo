using AbpOdataDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpOdataDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpOdataDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpOdataDemoApplicationContractsModule)
        )]
    public class AbpOdataDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
