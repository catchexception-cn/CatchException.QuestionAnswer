using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace CatchException.QuestionAnswer.EntityFrameworkCore;

public class QuestionAnswerHttpApiHostMigrationsDbContext : AbpDbContext<QuestionAnswerHttpApiHostMigrationsDbContext>
{
    public QuestionAnswerHttpApiHostMigrationsDbContext(DbContextOptions<QuestionAnswerHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureQuestionAnswer();
    }
}
