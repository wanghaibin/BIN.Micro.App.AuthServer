using BIN.Micro.App.AuthServer.Samples;
using Xunit;

namespace BIN.Micro.App.AuthServer.EntityFrameworkCore.Domains;

[Collection(AuthServerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AuthServerEntityFrameworkCoreTestModule>
{

}
