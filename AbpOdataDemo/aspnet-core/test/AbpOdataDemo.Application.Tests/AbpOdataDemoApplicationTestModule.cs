using Volo.Abp.Modularity;

namespace AbpOdataDemo
{
    [DependsOn(
        typeof(AbpOdataDemoApplicationModule),
        typeof(AbpOdataDemoDomainTestModule)
        )]
    public class AbpOdataDemoApplicationTestModule : AbpModule
    {

    }
}