using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CatchException.QuestionAnswer.EntityFrameworkCore;

public class QuestionAnswerHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<QuestionAnswerHttpApiHostMigrationsDbContext>
{
    public QuestionAnswerHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<QuestionAnswerHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("QuestionAnswer"));

        return new QuestionAnswerHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
