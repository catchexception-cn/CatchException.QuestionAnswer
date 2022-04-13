using CatchException.QuestionAnswer.Comments;

namespace CatchException.QuestionAnswer.Questions;

public class QuestionComment : Comment
{

    public Guid QuestionId { get; set; }


    protected QuestionComment()
    {

    }

    public QuestionComment(
        Guid id,
        Guid questionId,
        Guid repliedId,
        string text)
        : base(id, repliedId, text)
    {
        this.QuestionId = questionId;
    }
}