using CatchException.QuestionAnswer.Answers;
using CatchException.QuestionAnswer.Comments;
using CatchException.QuestionAnswer.Questions;

using Microsoft.EntityFrameworkCore;

using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CatchException.QuestionAnswer.EntityFrameworkCore;

[ConnectionStringName(QuestionAnswerDbProperties.ConnectionStringName)]
public class QuestionAnswerDbContext : AbpDbContext<QuestionAnswerDbContext>, IQuestionAnswerDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */
    public DbSet<Question> Questions { get; set; } = default!;
    public DbSet<Comment> Comments { get; set; } = default!;
    public DbSet<Answer> Answers { get; set; } = default!;

    public QuestionAnswerDbContext(DbContextOptions<QuestionAnswerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureQuestionAnswer();
    }
}
