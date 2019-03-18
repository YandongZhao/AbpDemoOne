using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpDemoOne.Configuration;
using Abp.Configuration.Startup;
using System.Reflection;
using System.Linq;

namespace AbpDemoOne.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpDemoOneWebCoreModule))]
    public class AbpDemoOneWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpDemoOneWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpDemoOneWebHostModule).GetAssembly());
            
        }
    }
}
