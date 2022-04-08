namespace CatchException.QuestionAnswer.Questions;

public record QuestionVote
{
    public Guid QuestionId { get; init; }

    public Guid VoterId { get; init; }

    public QuestionVoteType VoteType { get; init; }

    public QuestionVote(
        Guid questionId,
        Guid voterId,
        QuestionVoteType voteType)
    {
        QuestionId = questionId;
        VoterId = voterId;
        VoteType = voteType;
    }
}