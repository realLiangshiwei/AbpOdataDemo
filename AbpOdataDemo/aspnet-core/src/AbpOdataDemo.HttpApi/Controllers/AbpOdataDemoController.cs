using AbpOdataDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpOdataDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpOdataDemoController : AbpController
    {
        protected AbpOdataDemoController()
        {
            LocalizationResource = typeof(AbpOdataDemoResource);
        }
    }
}