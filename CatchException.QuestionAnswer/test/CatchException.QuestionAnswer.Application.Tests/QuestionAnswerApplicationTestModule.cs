using Volo.Abp.Modularity;

namespace CatchException.QuestionAnswer;

[DependsOn(
    typeof(QuestionAnswerApplicationModule),
    typeof(QuestionAnswerDomainTestModule)
    )]
public class QuestionAnswerApplicationTestModule : AbpModule
{

}
