using Volo.Abp.Modularity;

namespace Acme.QLSV;

[DependsOn(
    typeof(QLSVDomainModule),
    typeof(QLSVTestBaseModule)
)]
public class QLSVDomainTestModule : AbpModule
{

}
