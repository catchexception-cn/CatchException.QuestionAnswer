using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace CatchException.QuestionAnswer.MongoDB;

[ConnectionStringName(QuestionAnswerDbProperties.ConnectionStringName)]
public class QuestionAnswerMongoDbContext : AbpMongoDbContext, IQuestionAnswerMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureQuestionAnswer();
    }
}
