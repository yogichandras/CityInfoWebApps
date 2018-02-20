using System.Threading.Tasks;
using Abp.Application.Services;
using CityInfo.Sessions.Dto;

namespace CityInfo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
