using System.Threading.Tasks;
using Abp.Application.Services;
using abp.test.Configuration.Dto;

namespace abp.test.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}