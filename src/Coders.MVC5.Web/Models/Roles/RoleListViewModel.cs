using System.Collections.Generic;
using Coders.MVC5.Roles.Dto;

namespace Coders.MVC5.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}