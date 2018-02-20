using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CityInfo.MultiTenancy.Dto;

namespace CityInfo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
