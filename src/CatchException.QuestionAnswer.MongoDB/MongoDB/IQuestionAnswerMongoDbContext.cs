using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace CatchException.QuestionAnswer.MongoDB;

[ConnectionStringName(QuestionAnswerDbProperties.ConnectionStringName)]
public interface IQuestionAnswerMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
