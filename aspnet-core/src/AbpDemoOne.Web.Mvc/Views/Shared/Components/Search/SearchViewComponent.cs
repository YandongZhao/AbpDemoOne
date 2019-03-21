using System.Threading.Tasks;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;

namespace AbpDemoOne.Web.Views.Shared.Components.Search
{
    /// <summary>
    /// 简况组件
    /// </summary>
    public class SearchViewComponent : ViewComponent
    {
        private readonly IAbpSession _abpSession;

        /// <summary>
        /// 简况组件
        /// </summary>
        /// <param name="abpSession"></param>
        public SearchViewComponent(
            IAbpSession abpSession
            )
        {
            _abpSession = abpSession;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new SearchViewModel
            {
            };
            
            return View(model);
        }
    }
}
