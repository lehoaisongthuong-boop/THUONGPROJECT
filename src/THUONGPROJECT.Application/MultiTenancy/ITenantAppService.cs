using Abp.Application.Services;
using THUONGPROJECT.MultiTenancy.Dto;

namespace THUONGPROJECT.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

