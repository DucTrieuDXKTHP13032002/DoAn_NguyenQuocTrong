using Acme.QLSV.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.QLSV.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QLSVEntityFrameworkCoreModule),
    typeof(QLSVApplicationContractsModule)
)]
public class QLSVDbMigratorModule : AbpModule
{
}
