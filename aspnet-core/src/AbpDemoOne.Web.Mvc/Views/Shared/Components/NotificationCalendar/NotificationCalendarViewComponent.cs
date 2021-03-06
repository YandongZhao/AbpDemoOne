﻿using System.Threading.Tasks;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;

namespace AbpDemoOne.Web.Views.Shared.Components.NotificationCalendar
{
    /// <summary>
    /// 通知杂项组件
    /// </summary>
    public class NotificationCalendarViewComponent : ViewComponent
    {
        private readonly IAbpSession _abpSession;

        /// <summary>
        /// 简况组件
        /// </summary>
        /// <param name="abpSession"></param>
        public NotificationCalendarViewComponent(
            IAbpSession abpSession
            )
        {
            _abpSession = abpSession;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new NotificationCalendarViewModel
            {
            };
            
            return View(model);
        }
    }
}
