using Abp.AutoMapper;
using THUONGPROJECT.Roles.Dto;
using THUONGPROJECT.Web.Models.Common;

namespace THUONGPROJECT.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
