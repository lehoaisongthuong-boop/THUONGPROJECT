using System.Threading.Tasks;
using Abp.Application.Services;
using THUONGPROJECT.Authorization.Accounts.Dto;

namespace THUONGPROJECT.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
