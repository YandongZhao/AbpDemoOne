using Microsoft.AspNetCore.Antiforgery;
using AbpDemoOne.Controllers;

namespace AbpDemoOne.Web.Host.Controllers
{
    public class AntiForgeryController : AbpDemoOneControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
