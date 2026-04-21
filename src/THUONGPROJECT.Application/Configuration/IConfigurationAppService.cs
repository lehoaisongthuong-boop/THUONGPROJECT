using System.Threading.Tasks;
using THUONGPROJECT.Configuration.Dto;

namespace THUONGPROJECT.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
