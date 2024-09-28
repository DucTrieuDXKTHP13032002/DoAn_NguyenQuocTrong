using Volo.Abp.Modularity;

namespace Acme.QLSV;

[DependsOn(
    typeof(QLSVApplicationModule),
    typeof(QLSVDomainTestModule)
)]
public class QLSVApplicationTestModule : AbpModule
{

}
