using Localization.Resources.AbpUi;
using CatchException.QuestionAnswer.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace CatchException.QuestionAnswer;

[DependsOn(
    typeof(QuestionAnswerApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class QuestionAnswerHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(QuestionAnswerHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<QuestionAnswerResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
