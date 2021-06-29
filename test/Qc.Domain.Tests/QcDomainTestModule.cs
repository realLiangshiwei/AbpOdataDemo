using Qc.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qc
{
    [DependsOn(
        typeof(QcEntityFrameworkCoreTestModule)
        )]
    public class QcDomainTestModule : AbpModule
    {

    }
}