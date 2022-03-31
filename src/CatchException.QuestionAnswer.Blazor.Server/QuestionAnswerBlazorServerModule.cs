using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace CatchException.QuestionAnswer.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(QuestionAnswerBlazorModule)
    )]
public class QuestionAnswerBlazorServerModule : AbpModule
{

}
