using System.Threading.Tasks;
using Abp.Application.Services;
using abp.test.Authorization.Accounts.Dto;

namespace abp.test.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
