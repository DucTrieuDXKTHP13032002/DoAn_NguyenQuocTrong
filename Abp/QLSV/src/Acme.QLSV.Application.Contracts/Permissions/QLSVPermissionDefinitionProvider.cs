using Acme.QLSV.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.QLSV.Permissions;

public class QLSVPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(QLSVPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(QLSVPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<QLSVResource>(name);
    }
}
