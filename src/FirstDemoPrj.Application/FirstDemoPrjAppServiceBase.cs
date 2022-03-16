using Abp.Application.Services;

namespace FirstDemoPrj
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class FirstDemoPrjAppServiceBase : ApplicationService
    {
        protected FirstDemoPrjAppServiceBase()
        {
            LocalizationSourceName = FirstDemoPrjConsts.LocalizationSourceName;
        }
    }
}