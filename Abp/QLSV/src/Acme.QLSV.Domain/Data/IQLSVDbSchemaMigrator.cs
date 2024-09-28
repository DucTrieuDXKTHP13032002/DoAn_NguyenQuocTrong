using System.Threading.Tasks;

namespace Acme.QLSV.Data;

public interface IQLSVDbSchemaMigrator
{
    Task MigrateAsync();
}
