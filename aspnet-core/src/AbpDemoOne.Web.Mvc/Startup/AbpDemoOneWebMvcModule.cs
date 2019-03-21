using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpDemoOne.Configuration;
using Abp.Configuration.Startup;

namespace AbpDemoOne.Web.Startup
{
    [DependsOn(typeof(AbpDemoOneWebCoreModule))]
    public class AbpDemoOneWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpDemoOneWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<AbpDemoOneNavigationProvider>();
            Configuration.Modules.AbpWebCommon().SendAllExceptionsToClients = true;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpDemoOneWebMvcModule).GetAssembly());
        }
    }
}
