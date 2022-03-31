using CatchException.QuestionAnswer.Localization;
using Volo.Abp.Application.Services;

namespace CatchException.QuestionAnswer;

public abstract class QuestionAnswerAppService : ApplicationService
{
    protected QuestionAnswerAppService()
    {
        LocalizationResource = typeof(QuestionAnswerResource);
        ObjectMapperContext = typeof(QuestionAnswerApplicationModule);
    }
}
