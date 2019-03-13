using System.Threading.Tasks;
using Abp.Application.Services;
using AbpDemoOne.Sessions.Dto;

namespace AbpDemoOne.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
