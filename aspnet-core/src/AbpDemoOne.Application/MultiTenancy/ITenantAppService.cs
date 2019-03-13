using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpDemoOne.MultiTenancy.Dto;

namespace AbpDemoOne.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

