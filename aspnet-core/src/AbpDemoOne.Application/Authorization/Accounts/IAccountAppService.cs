using System.Threading.Tasks;
using Abp.Application.Services;
using AbpDemoOne.Authorization.Accounts.Dto;

namespace AbpDemoOne.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
