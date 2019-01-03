using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using abp.test.Authorization.Users;
using abp.test.Users;

namespace abp.test.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
