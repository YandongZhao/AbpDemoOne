using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbpDemoOne.Web.Views.Shared.Components.MPSeach
{
    /// <summary>
    /// 手机搜索框组件
    /// </summary>
    public class MPSeachViewComponent : ViewComponent
    {
        private readonly IAbpSession _abpSession;

        /// <summary>
        /// 简况组件
        /// </summary>
        /// <param name="abpSession"></param>
        public MPSeachViewComponent(
            IAbpSession abpSession
            )
        {
            _abpSession = abpSession;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new MPSeachViewModel
            {
            };

            return View(model);
        }
    }
}
