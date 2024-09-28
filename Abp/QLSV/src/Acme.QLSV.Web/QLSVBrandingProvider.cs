using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.QLSV.Web;

[Dependency(ReplaceServices = true)]
public class QLSVBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "QLSV";
}
