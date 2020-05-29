using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace AbpOdataDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbpOdataDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpOdataDemo";
    }
}
