using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AbpDemoOne.Controllers;

namespace AbpDemoOne.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AbpDemoOneControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
