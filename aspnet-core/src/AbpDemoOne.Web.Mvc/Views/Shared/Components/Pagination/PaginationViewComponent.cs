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

        public async Task<IViewComponentResult> InvokeAsync(PaginationViewModel input)
        {
            input.PageSize = input.PageSize < 1 ? 10 : input.PageSize;
            input.PageIndex = input.PageIndex < 1 ? 1 : input.PageIndex;
           
            var viewModel = new PaginationViewModel
            {
                PageCont = (input.TotalCount/input.PageSize+1),
                PageFrom=input.PageFrom<1?1:input.PageSize*(input.PageIndex-1)+1,
                PageEnd= input.PageCont < input.PageSize? input.TotalCount : input.PageSize*(input.PageIndex+1)<input.TotalCount ? input.TotalCount : input.PageSize * (input.PageIndex + 1),
                PageIndex=input.PageIndex<1?1:input.PageIndex,
                PageSize=input.PageSize,
                TotalCount=input.TotalCount
            };

            return View(viewModel);
        }
    }
}
