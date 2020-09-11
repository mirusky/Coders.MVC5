using System.Collections.Generic;
using Coders.MVC5.Roles.Dto;
using Coders.MVC5.Users.Dto;

namespace Coders.MVC5.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}