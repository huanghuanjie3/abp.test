using Abp.Application.Services;
using Abp.Application.Services.Dto;
using abp.test.MultiTenancy.Dto;

namespace abp.test.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
