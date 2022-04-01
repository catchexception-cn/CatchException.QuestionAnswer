using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CatchException.QuestionAnswer.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class QuestionAnswerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "QuestionAnswer";
}
