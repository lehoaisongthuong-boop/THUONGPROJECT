using System.Threading.Tasks;
using Abp.Application.Services;
using THUONGPROJECT.Sessions.Dto;

namespace THUONGPROJECT.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
