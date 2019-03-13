using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpDemoOne.Controllers
{
    public abstract class AbpDemoOneControllerBase: AbpController
    {
        protected AbpDemoOneControllerBase()
        {
            LocalizationSourceName = AbpDemoOneConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
