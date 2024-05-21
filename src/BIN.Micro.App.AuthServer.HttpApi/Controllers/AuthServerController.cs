using BIN.Micro.App.AuthServer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BIN.Micro.App.AuthServer.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AuthServerController : AbpControllerBase
{
    protected AuthServerController()
    {
        LocalizationResource = typeof(AuthServerResource);
    }
}
