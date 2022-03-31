using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace CatchException.QuestionAnswer;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(QuestionAnswerDomainSharedModule)
)]
public class QuestionAnswerDomainModule : AbpModule
{

}
