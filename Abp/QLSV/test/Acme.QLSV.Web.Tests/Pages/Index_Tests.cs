using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.QLSV.Pages;

[Collection(QLSVTestConsts.CollectionDefinitionName)]
public class Index_Tests : QLSVWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
