using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace CatchException.QuestionAnswer;

[DependsOn(
    typeof(QuestionAnswerDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class QuestionAnswerApplicationContractsModule : AbpModule
{

}
