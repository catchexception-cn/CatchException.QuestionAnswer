using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace CatchException.QuestionAnswer;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(QuestionAnswerHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class QuestionAnswerConsoleApiClientModule : AbpModule
{

}
