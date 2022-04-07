namespace CatchException.QuestionAnswer.Answers;

public record AnswerVote
{
    public Guid AnswerId { get; init; }
    public Guid VoterId { get; init; }
    public AnswerVoteType VoteType { get; init; }

    internal AnswerVote(
        Guid answerId,
        Guid voterId,
        AnswerVoteType voteType)
    {
        AnswerId = answerId;
        VoterId = voterId;
        VoteType = voteType;
    }
}