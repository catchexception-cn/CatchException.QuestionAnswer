using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CatchException.QuestionAnswer.EntityFrameworkCore;

[DependsOn(
    typeof(QuestionAnswerDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class QuestionAnswerEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<QuestionAnswerDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
