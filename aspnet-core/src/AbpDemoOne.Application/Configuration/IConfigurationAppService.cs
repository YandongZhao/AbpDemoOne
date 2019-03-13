using System.Threading.Tasks;
using AbpDemoOne.Configuration.Dto;

namespace AbpDemoOne.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
