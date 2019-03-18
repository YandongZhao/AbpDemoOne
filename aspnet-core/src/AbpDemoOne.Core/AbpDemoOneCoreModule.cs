using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using AbpDemoOne.Authorization.Roles;
using AbpDemoOne.Authorization.Users;
using AbpDemoOne.Configuration;
using AbpDemoOne.Localization;
using AbpDemoOne.MultiTenancy;
using AbpDemoOne.Timing;

namespace AbpDemoOne
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AbpDemoOneCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            AbpDemoOneLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = AbpDemoOneConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpDemoOneCoreModule).GetAssembly());
            
            //var sqlExecuter = IocManager.Instance.Resolve<ISqlExecuter>();
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
            
        }
    }
}
