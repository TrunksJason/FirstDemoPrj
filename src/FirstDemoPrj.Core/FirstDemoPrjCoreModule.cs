using Abp.Modules;
using Abp.Reflection.Extensions;
using FirstDemoPrj.Localization;

namespace FirstDemoPrj
{
    public class FirstDemoPrjCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            FirstDemoPrjLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = FirstDemoPrjConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FirstDemoPrjCoreModule).GetAssembly());
        }
    }
}