using Abp.Authorization;
using ShareAdmin.Authorization.Roles;
using ShareAdmin.Authorization.Users;

namespace ShareAdmin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
