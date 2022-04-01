using Microsoft.Extensions.DependencyInjection;
using CatchException.QuestionAnswer.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace CatchException.QuestionAnswer.Blazor;

[DependsOn(
    typeof(QuestionAnswerApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class QuestionAnswerBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<QuestionAnswerBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<QuestionAnswerBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new QuestionAnswerMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(QuestionAnswerBlazorModule).Assembly);
        });
    }
}
