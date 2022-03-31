using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CatchException.QuestionAnswer;

[Dependency(ReplaceServices = true)]
public class QuestionAnswerBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "QuestionAnswer";
}
