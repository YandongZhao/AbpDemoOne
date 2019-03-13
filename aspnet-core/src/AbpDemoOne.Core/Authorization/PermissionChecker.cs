using Abp.Authorization;
using AbpDemoOne.Authorization.Roles;
using AbpDemoOne.Authorization.Users;

namespace AbpDemoOne.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
