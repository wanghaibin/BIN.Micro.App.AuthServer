using Volo.Abp.Modularity;

namespace BIN.Micro.App.AuthServer;

public abstract class AuthServerApplicationTestBase<TStartupModule> : AuthServerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
