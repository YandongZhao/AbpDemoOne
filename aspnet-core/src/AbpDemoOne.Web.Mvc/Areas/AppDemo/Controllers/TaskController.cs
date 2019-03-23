using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbpDemoOne.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AbpDemoOne.Web.Mvc.AppDemo.Controllers
{
    [Area("AppDemo")]
    public class TaskController : AbpDemoOneControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manager()
        {
            return View();
        }
    }
}