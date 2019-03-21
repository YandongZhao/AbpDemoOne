using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpDemoOne.Authorization;

namespace AbpDemoOne
{
    [DependsOn(
        typeof(AbpDemoOneCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpDemoOneApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpDemoOneAuthorizationProvider>();
            
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpDemoOneApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
