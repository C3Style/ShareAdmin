using System.Threading.Tasks;
using Abp.Application.Services;
using ShareAdmin.Configuration.Dto;

namespace ShareAdmin.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}