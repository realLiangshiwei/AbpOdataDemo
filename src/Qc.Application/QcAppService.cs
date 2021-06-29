using System;
using System.Collections.Generic;
using System.Text;
using Qc.Localization;
using Volo.Abp.Application.Services;

namespace Qc
{
    /* Inherit your application services from this class.
     */
    public abstract class QcAppService : ApplicationService
    {
        protected QcAppService()
        {
            LocalizationResource = typeof(QcResource);
        }
    }
}
