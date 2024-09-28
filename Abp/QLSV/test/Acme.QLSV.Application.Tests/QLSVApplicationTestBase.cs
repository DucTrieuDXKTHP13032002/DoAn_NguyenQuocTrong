using Volo.Abp.Modularity;

namespace Acme.QLSV;

public abstract class QLSVApplicationTestBase<TStartupModule> : QLSVTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
