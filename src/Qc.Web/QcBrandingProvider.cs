using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Qc.Web
{
    [Dependency(ReplaceServices = true)]
    public class QcBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Qc";
    }
}
