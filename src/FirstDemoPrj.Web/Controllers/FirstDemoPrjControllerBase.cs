using Abp.AspNetCore.Mvc.Controllers;

namespace FirstDemoPrj.Web.Controllers
{
    public abstract class FirstDemoPrjControllerBase: AbpController
    {
        protected FirstDemoPrjControllerBase()
        {
            LocalizationSourceName = FirstDemoPrjConsts.LocalizationSourceName;
        }
    }
}