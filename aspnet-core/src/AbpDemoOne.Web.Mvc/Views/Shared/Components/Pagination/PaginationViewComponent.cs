using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Configuration;
using AbpDemoOne.Configuration;
using AbpDemoOne.Configuration.Ui;

namespace AbpDemoOne.Web.Views.Shared.Components.Pagination
{
    public class PaginationViewComponent : AbpDemoOneViewComponent
    {
        private readonly ISettingManager _settingManager;

        public PaginationViewComponent(ISettingManager settingManager)
        {
            _settingManager = settingManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(int pageCont)
        {
           
            var viewModel = new PaginationViewModel
            {
                PageCont = 10
            };

            return View(viewModel);
        }
    }
}
