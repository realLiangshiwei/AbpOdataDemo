using Volo.Abp.Modularity;

namespace Qc
{
    [DependsOn(
        typeof(QcApplicationModule),
        typeof(QcDomainTestModule)
        )]
    public class QcApplicationTestModule : AbpModule
    {

    }
}