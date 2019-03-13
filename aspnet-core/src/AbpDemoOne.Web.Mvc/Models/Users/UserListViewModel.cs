using System.Collections.Generic;
using AbpDemoOne.Roles.Dto;
using AbpDemoOne.Users.Dto;

namespace AbpDemoOne.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
