using AbpOdataDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpOdataDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbpOdataDemoPageModel : AbpPageModel
    {
        protected AbpOdataDemoPageModel()
        {
            LocalizationResourceType = typeof(AbpOdataDemoResource);
        }
    }
}