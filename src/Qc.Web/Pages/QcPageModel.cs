using Qc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Qc.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class QcPageModel : AbpPageModel
    {
        protected QcPageModel()
        {
            LocalizationResourceType = typeof(QcResource);
        }
    }
}