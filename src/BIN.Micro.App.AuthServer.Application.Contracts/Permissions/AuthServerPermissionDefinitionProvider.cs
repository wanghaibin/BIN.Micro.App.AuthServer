using BIN.Micro.App.AuthServer.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BIN.Micro.App.AuthServer.Permissions;

public class AuthServerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AuthServerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AuthServerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AuthServerResource>(name);
    }
}
