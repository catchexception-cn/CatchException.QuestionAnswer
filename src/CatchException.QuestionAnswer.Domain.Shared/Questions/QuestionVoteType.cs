namespace CatchException.QuestionAnswer.Questions;

public enum QuestionVoteType
{
    WellOrganized = 1,
    Reproducible,
    Readable,

    UnReadable = -QuestionVoteType.Readable,
    NotReproducible = -QuestionVoteType.Reproducible,
    PoorlyOrganized = -QuestionVoteType.WellOrganized,
}