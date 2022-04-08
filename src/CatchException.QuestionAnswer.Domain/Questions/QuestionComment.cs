using CatchException.QuestionAnswer.Comments;

namespace CatchException.QuestionAnswer.Questions;

public class QuestionComment : Comment
{
    protected QuestionComment()
    {

    }

    public QuestionComment(
        Guid id,
        Guid questionId,
        Guid repliedId,
        string text)
        : base(id, CommentType.Question, questionId, repliedId, text)
    {

    }
}