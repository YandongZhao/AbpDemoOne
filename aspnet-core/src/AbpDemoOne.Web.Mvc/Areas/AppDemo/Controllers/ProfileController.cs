using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbpDemoOne.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AbpDemoOne.Web.Mvc.AppDemo.Controllers
{
    [Area("AppDemo")]
    public class ProfileController : AbpDemoOneControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}