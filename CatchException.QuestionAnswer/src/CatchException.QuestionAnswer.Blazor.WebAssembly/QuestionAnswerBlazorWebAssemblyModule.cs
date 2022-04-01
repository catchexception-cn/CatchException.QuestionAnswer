using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace CatchException.QuestionAnswer.Blazor.WebAssembly;

[DependsOn(
    typeof(QuestionAnswerBlazorModule),
    typeof(QuestionAnswerHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class QuestionAnswerBlazorWebAssemblyModule : AbpModule
{

}
