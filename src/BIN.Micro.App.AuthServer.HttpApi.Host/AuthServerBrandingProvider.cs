using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BIN.Micro.App.AuthServer;

[Dependency(ReplaceServices = true)]
public class AuthServerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AuthServer";
}
