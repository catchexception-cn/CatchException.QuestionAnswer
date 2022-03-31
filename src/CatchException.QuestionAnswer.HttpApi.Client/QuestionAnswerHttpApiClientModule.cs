using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace CatchException.QuestionAnswer;

[DependsOn(
    typeof(QuestionAnswerApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class QuestionAnswerHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(QuestionAnswerApplicationContractsModule).Assembly,
            QuestionAnswerRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<QuestionAnswerHttpApiClientModule>();
        });

    }
}
