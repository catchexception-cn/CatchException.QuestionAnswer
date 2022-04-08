namespace CatchException.QuestionAnswer.Answers;

public enum AnswerVoteType
{
    WellOrganized = 1,
    SolvedTheProblem,
    Readable,
    Professional,

    UnReadable = -AnswerVoteType.Readable,
    CanNotSolveTheProblem = -AnswerVoteType.SolvedTheProblem,
    PoorlyOrganized = -AnswerVoteType.WellOrganized,
    Unprofessional = -AnswerVoteType.Professional
}