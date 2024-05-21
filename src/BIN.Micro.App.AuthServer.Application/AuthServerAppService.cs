using System;
using System.Collections.Generic;
using System.Text;
using BIN.Micro.App.AuthServer.Localization;
using Volo.Abp.Application.Services;

namespace BIN.Micro.App.AuthServer;

/* Inherit your application services from this class.
 */
public abstract class AuthServerAppService : ApplicationService
{
    protected AuthServerAppService()
    {
        LocalizationResource = typeof(AuthServerResource);
    }
}
