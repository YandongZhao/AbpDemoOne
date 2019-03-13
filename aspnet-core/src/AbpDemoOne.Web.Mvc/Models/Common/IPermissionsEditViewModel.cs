using System.Collections.Generic;
using AbpDemoOne.Roles.Dto;

namespace AbpDemoOne.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}