using System.Collections.Generic;
using THUONGPROJECT.Roles.Dto;

namespace THUONGPROJECT.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
