using CatchException.QuestionAnswer.Comments;

namespace CatchException.QuestionAnswer.Answers;

public class AnswerComment : Comment
{

    public Guid AnswerId { get; set; }

    protected AnswerComment()
    {

    }

    public AnswerComment(
        Guid id,
        Guid answerId,
        Guid repliedId,
        string text)
        : base(id, repliedId, text)
    {
        this.AnswerId = answerId;
    }
}