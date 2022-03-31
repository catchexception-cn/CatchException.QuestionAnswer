using CatchException.QuestionAnswer.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CatchException.QuestionAnswer.Pages;

public abstract class QuestionAnswerPageModel : AbpPageModel
{
    protected QuestionAnswerPageModel()
    {
        LocalizationResourceType = typeof(QuestionAnswerResource);
    }
}
