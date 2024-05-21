using Volo.Abp.Modularity;

namespace BIN.Micro.App.AuthServer;

[DependsOn(
    typeof(AuthServerDomainModule),
    typeof(AuthServerTestBaseModule)
)]
public class AuthServerDomainTestModule : AbpModule
{

}
