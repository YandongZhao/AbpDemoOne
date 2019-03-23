using AbpDemoOne.Configuration.Ui;

namespace AbpDemoOne.Web.Views.Shared.Components.Pagination
{
    /// <summary>
    /// 分页实体
    /// </summary>
    public class PaginationViewModel
    {
        /// <summary>
        /// 显示开始记录数
        /// </summary>
        public int PageFrom { get; set; }

        /// <summary>
        /// 显示结束记录数
        /// </summary>
        public int PageEnd { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCont { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int TotalCount { get; set; }
    }
}
