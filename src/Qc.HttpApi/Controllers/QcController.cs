using Qc.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qc.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class QcController : AbpController
    {
        protected QcController()
        {
            LocalizationResource = typeof(QcResource);
        }
    }
}