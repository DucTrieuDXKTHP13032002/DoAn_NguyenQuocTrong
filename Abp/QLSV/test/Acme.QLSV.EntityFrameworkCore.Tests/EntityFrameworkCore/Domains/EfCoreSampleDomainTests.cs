using Acme.QLSV.Samples;
using Xunit;

namespace Acme.QLSV.EntityFrameworkCore.Domains;

[Collection(QLSVTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<QLSVEntityFrameworkCoreTestModule>
{

}
