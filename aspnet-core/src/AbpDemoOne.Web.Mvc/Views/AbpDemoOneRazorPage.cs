using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AbpDemoOne.Web.Views
{
    public abstract class AbpDemoOneRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpDemoOneRazorPage()
        {
            LocalizationSourceName = AbpDemoOneConsts.LocalizationSourceName;
        }
    }
}
