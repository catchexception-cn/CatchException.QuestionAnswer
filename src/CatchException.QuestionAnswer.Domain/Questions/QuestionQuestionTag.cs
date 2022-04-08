using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Questions;

public record QuestionQuestionTag
{
    public Guid QuestionId { get; init; }

    public Guid TagId { get; init; }

    public QuestionQuestionTag(
        Guid questionId,
        Guid tagId)
    {
        QuestionId = questionId;
        TagId = tagId;
    }
}