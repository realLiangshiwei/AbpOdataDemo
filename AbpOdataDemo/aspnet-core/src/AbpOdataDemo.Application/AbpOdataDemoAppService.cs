using System;
using System.Collections.Generic;
using System.Text;
using AbpOdataDemo.Localization;
using Volo.Abp.Application.Services;

namespace AbpOdataDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpOdataDemoAppService : ApplicationService
    {
        protected AbpOdataDemoAppService()
        {
            LocalizationResource = typeof(AbpOdataDemoResource);
        }
    }
}
