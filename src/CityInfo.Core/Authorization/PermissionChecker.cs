using Abp.Authorization;
using CityInfo.Authorization.Roles;
using CityInfo.Authorization.Users;

namespace CityInfo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
