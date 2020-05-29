using AbpOdataDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpOdataDemo
{
    [DependsOn(
        typeof(AbpOdataDemoEntityFrameworkCoreTestModule)
        )]
    public class AbpOdataDemoDomainTestModule : AbpModule
    {

    }
}