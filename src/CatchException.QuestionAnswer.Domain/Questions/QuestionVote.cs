namespace CatchException.QuestionAnswer.Questions;

public record QuestionVote
{
    public Guid QuestionId { get; init; }

    public Guid VoterId { get; init; }

    public VoteType VoteType { get; init; }

    public DateTime CreationTime { get; init; }

    public QuestionVote(
        Guid questionId,
        Guid voterId,
        VoteType voteType,
        DateTime creationTime)
    {
        QuestionId = questionId;
        VoterId = voterId;
        VoteType = voteType;
        CreationTime = creationTime;
    }
}