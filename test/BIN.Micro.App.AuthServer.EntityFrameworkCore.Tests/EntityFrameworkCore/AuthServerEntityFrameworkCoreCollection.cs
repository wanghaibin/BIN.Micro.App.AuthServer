using Xunit;

namespace BIN.Micro.App.AuthServer.EntityFrameworkCore;

[CollectionDefinition(AuthServerTestConsts.CollectionDefinitionName)]
public class AuthServerEntityFrameworkCoreCollection : ICollectionFixture<AuthServerEntityFrameworkCoreFixture>
{

}
