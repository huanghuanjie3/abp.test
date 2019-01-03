using System.Threading.Tasks;
using Abp.Application.Services;
using abp.test.Sessions.Dto;

namespace abp.test.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
