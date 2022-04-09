using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Questions;

public record QuestionQuestionTag(Guid QuestionId, Guid TagId);