using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.QLSV.Data;

/* This is used if database provider does't define
 * IQLSVDbSchemaMigrator implementation.
 */
public class NullQLSVDbSchemaMigrator : IQLSVDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
