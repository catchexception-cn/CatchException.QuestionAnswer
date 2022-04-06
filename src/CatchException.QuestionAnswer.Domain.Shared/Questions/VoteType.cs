namespace CatchException.QuestionAnswer.Questions;

public enum VoteType
{
    WellOrganized = 1,
    Reproducible,
    Readable,

    UnReadable = -VoteType.Readable,
    NotReproducible = -VoteType.Reproducible,
    PoorlyOrganized = -VoteType.WellOrganized,
}