using Volo.Abp;
using Volo.Abp.MongoDB;

namespace CatchException.QuestionAnswer.MongoDB;

public static class QuestionAnswerMongoDbContextExtensions
{
    public static void ConfigureQuestionAnswer(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
