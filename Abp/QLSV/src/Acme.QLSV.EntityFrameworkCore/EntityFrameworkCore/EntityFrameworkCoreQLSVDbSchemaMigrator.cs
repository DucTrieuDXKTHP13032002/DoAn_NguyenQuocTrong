using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.QLSV.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.QLSV.EntityFrameworkCore;

public class EntityFrameworkCoreQLSVDbSchemaMigrator
    : IQLSVDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreQLSVDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the QLSVDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<QLSVDbContext>()
            .Database
            .MigrateAsync();
    }
}
