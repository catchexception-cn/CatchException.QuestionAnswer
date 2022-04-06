using CatchException.Tagging.Tagging;

using Volo.Abp.Uow;

namespace CatchException.QuestionAnswer.Questions;

public class QuestionTagLookupService : TagLookupService<QuestionTag, IQuestionTagRepository>, IQuestionTagLookupService
{
    public QuestionTagLookupService(IQuestionTagRepository tagRepository, IUnitOfWorkManager unitOfWorkManager)
        : base(tagRepository, unitOfWorkManager)
    {
    }

    protected override QuestionTag CreateTag(ITagData externalTag)
    {
        return new QuestionTag(externalTag);
    }
}