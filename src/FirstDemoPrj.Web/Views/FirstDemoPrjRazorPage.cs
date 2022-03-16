using Abp.AspNetCore.Mvc.Views;

namespace FirstDemoPrj.Web.Views
{
    public abstract class FirstDemoPrjRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected FirstDemoPrjRazorPage()
        {
            LocalizationSourceName = FirstDemoPrjConsts.LocalizationSourceName;
        }
    }
}
