using CatchException.QuestionAnswer.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CatchException.QuestionAnswer;

public abstract class QuestionAnswerController : AbpControllerBase
{
    protected QuestionAnswerController()
    {
        LocalizationResource = typeof(QuestionAnswerResource);
    }
}
