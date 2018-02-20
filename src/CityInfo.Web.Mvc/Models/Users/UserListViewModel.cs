using System.Collections.Generic;
using CityInfo.Roles.Dto;
using CityInfo.Users.Dto;

namespace CityInfo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
