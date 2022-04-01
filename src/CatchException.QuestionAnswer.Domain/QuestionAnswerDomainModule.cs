using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.Users;

namespace CatchException.QuestionAnswer;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpUsersDomainModule),
    typeof(QuestionAnswerDomainSharedModule)
)]
public class QuestionAnswerDomainModule : AbpModule
{

}
