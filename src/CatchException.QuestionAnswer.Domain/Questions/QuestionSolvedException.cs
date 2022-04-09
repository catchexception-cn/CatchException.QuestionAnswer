using Volo.Abp;

namespace CatchException.QuestionAnswer.Questions;

public class QuestionSolvedException : UserFriendlyException
{
    public QuestionSolvedException()
    : base("问题已解决")
    { }
}