using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace CatchException.QuestionAnswer.MongoDB;

[DependsOn(
    typeof(QuestionAnswerDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class QuestionAnswerMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<QuestionAnswerMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
