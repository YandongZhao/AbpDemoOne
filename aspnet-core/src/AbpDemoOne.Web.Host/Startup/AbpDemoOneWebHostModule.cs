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

           // ConfigureSwaggerUi();
        }
        //private void ConfigureSwaggerUi()
        //{
        //    Configuration.Modules.AbpWebApi().HttpConfiguration
        //        .EnableSwagger(c =>
        //        {
        //            c.SingleApiVersion("v1", "AbpDemoOne.Web");
        //            c.IncludeXmlComments(GetXmlCommentsPath("AbpDemoOne.Core"));
        //            c.IncludeXmlComments(GetXmlCommentsPath("AbpDemoOne.Application"));
        //            c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
        //           // c.CustomProvider((defaultProvider) => new CachingSwaggerProvider(defaultProvider));

        //        })
        //        .EnableSwaggerUi(c =>
        //        {
        //            c.InjectJavaScript(Assembly.GetAssembly(typeof(AbpDemoOneWebHostModule)), "AbpDemoOne.Web.Host.wwwroot.swagger.language_zh_CN.js");
        //        });
        //}
        //private static string GetXmlCommentsPath(string subName)
        //{
        //    var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
        //    var filePath = basePath + subName + ".xml";
        //    return filePath;
        //}
    }
}
