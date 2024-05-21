using Volo.Abp.Modularity;

namespace BIN.Micro.App.AuthServer;

[DependsOn(
    typeof(AuthServerApplicationModule),
    typeof(AuthServerDomainTestModule)
)]
public class AuthServerApplicationTestModule : AbpModule
{

}
