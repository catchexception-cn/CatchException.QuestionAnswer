using CatchException.QuestionAnswer.Comments;
using CatchException.QuestionAnswer.Questions;

using Microsoft.EntityFrameworkCore;

using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace CatchException.QuestionAnswer.EntityFrameworkCore;

[ConnectionStringName(QuestionAnswerDbProperties.ConnectionStringName)]
public interface IQuestionAnswerDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<Question> Questions { get; }
    DbSet<Comment> Comments { get; }
}
