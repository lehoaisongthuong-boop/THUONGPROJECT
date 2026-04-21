using Abp.Authorization;
using THUONGPROJECT.Authorization.Roles;
using THUONGPROJECT.Authorization.Users;

namespace THUONGPROJECT.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
