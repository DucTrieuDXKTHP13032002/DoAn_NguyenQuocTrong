using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.QLSV.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class QLSVDbContextFactory : IDesignTimeDbContextFactory<QLSVDbContext>
{
    public QLSVDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        QLSVEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<QLSVDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new QLSVDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.QLSV.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
