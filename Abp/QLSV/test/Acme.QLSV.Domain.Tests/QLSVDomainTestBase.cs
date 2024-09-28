using Volo.Abp.Modularity;

namespace Acme.QLSV;

/* Inherit from this class for your domain layer tests. */
public abstract class QLSVDomainTestBase<TStartupModule> : QLSVTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
