using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abp.test.Roles.Dto;
using abp.test.Users.Dto;

namespace abp.test.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}