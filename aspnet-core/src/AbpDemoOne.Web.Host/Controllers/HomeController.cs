using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using AbpDemoOne.Controllers;
using Castle.Core.Logging;

namespace AbpDemoOne.Web.Host.Controllers
{
    public class HomeController : AbpDemoOneControllerBase
    {
        private readonly INotificationPublisher _notificationPublisher;
        public  ILogger _logger { get; set; }

        public HomeController(INotificationPublisher notificationPublisher)
        {
            _notificationPublisher = notificationPublisher;
            _logger = NullLogger.Instance;
        }

        public IActionResult Index()
        {
            _logger.Debug("这是一个Debug");
            _logger.Info("这是一个Info");
            _logger.Error("这是一个Error");
            _logger.Fatal("这是一个Fatal");
            _logger.Warn("这是一个Warn");
            _logger.InfoFormat("日志记录");

            return Redirect("/swagger");
        }

        /// <summary>
        /// This is a demo code to demonstrate sending notification to default tenant admin and host admin uers.
        /// Don't use this code in production !!!
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ActionResult> TestNotification(string message = "")
        {
            if (message.IsNullOrEmpty())
            {
                message = "This is a test notification, created at " + Clock.Now;
            }

            var defaultTenantAdmin = new UserIdentifier(1, 2);
            var hostAdmin = new UserIdentifier(null, 1);

            await _notificationPublisher.PublishAsync(
                "App.SimpleMessage",
                new MessageNotificationData(message),
                severity: NotificationSeverity.Info,
                userIds: new[] { defaultTenantAdmin, hostAdmin }
            );

            return Content("Sent notification: " + message);
        }
    }
}
