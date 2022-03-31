using CatchException.QuestionAnswer.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CatchException.QuestionAnswer.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class QuestionAnswerPageModel : AbpPageModel
{
    protected QuestionAnswerPageModel()
    {
        LocalizationResourceType = typeof(QuestionAnswerResource);
        ObjectMapperContext = typeof(QuestionAnswerWebModule);
    }
}
