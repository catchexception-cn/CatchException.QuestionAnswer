using Volo.Abp.Bundling;

namespace CatchException.QuestionAnswer.Blazor.Host;

public class QuestionAnswerBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
