using CatchException.QuestionAnswer.Localization;
using Volo.Abp.AspNetCore.Components;

namespace CatchException.QuestionAnswer.Blazor.Server.Host;

public abstract class QuestionAnswerComponentBase : AbpComponentBase
{
    protected QuestionAnswerComponentBase()
    {
        LocalizationResource = typeof(QuestionAnswerResource);
    }
}
