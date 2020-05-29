using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace AbpOdataDemo.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(AbpOdataDemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AbpOdataDemoConsoleApiClientModule : AbpModule
    {
        
    }
}
