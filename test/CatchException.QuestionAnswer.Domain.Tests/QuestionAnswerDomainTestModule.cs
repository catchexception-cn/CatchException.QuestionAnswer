using CatchException.QuestionAnswer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CatchException.QuestionAnswer;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(QuestionAnswerEntityFrameworkCoreTestModule)
    )]
public class QuestionAnswerDomainTestModule : AbpModule
{

}
