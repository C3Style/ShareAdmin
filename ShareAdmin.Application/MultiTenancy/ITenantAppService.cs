using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ShareAdmin.MultiTenancy.Dto;

namespace ShareAdmin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
