using BIN.Micro.App.AuthServer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace BIN.Micro.App.AuthServer.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(AuthServerEntityFrameworkCoreModule),
    typeof(AuthServerApplicationContractsModule)
    )]
public class AuthServerDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "AuthServer:"; });
    }
}
