using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using abp.test.MultiTenancy;

namespace abp.test.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}