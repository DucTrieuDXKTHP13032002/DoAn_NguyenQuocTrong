using Xunit;

namespace Acme.QLSV.EntityFrameworkCore;

[CollectionDefinition(QLSVTestConsts.CollectionDefinitionName)]
public class QLSVEntityFrameworkCoreCollection : ICollectionFixture<QLSVEntityFrameworkCoreFixture>
{

}
