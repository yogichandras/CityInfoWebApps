using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CityInfo.Roles.Dto;
using CityInfo.Users.Dto;

namespace CityInfo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
