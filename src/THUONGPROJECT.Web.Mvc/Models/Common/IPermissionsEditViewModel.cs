using System.Collections.Generic;
using THUONGPROJECT.Roles.Dto;

namespace THUONGPROJECT.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}