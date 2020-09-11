using Abp.Authorization;
using Coders.MVC5.Authorization.Roles;
using Coders.MVC5.Authorization.Users;

namespace Coders.MVC5.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
