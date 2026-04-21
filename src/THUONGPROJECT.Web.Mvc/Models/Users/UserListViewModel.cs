using System.Collections.Generic;
using THUONGPROJECT.Roles.Dto;

namespace THUONGPROJECT.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
