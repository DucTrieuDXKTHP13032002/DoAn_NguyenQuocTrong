using Acme.QLSV.Samples;
using Xunit;

namespace Acme.QLSV.EntityFrameworkCore.Applications;

[Collection(QLSVTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<QLSVEntityFrameworkCoreTestModule>
{

}
