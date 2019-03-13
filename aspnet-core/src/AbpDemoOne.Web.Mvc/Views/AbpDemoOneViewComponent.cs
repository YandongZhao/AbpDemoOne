using Abp.AspNetCore.Mvc.ViewComponents;

namespace AbpDemoOne.Web.Views
{
    public abstract class AbpDemoOneViewComponent : AbpViewComponent
    {
        protected AbpDemoOneViewComponent()
        {
            LocalizationSourceName = AbpDemoOneConsts.LocalizationSourceName;
        }
    }
}
