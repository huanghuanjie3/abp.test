using Abp.Authorization;
using abp.test.Authorization.Roles;
using abp.test.Authorization.Users;

namespace abp.test.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
