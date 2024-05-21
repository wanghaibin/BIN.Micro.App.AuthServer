using BIN.Micro.App.AuthServer.Samples;
using Xunit;

namespace BIN.Micro.App.AuthServer.EntityFrameworkCore.Applications;

[Collection(AuthServerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AuthServerEntityFrameworkCoreTestModule>
{

}
