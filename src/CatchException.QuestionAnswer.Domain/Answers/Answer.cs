using CatchException.QuestionAnswer.Contents;

using Volo.Abp;

namespace CatchException.QuestionAnswer.Answers;

public class Answer : ContentWithSnapshot
{
    public virtual Guid QuestionId { get; protected set; }

    private readonly List<AnswerVote> _votes;
    public virtual IReadOnlyCollection<AnswerVote> Votes => _votes;

    protected Answer()
    {
        _votes = new List<AnswerVote>();
    }

    public Answer(
        Guid id,
        Guid questionId,
        string content) : base(id)
    {
        QuestionId = questionId;
        SetContent(content);

        _votes = new List<AnswerVote>();
    }

    public Answer Vote(
        Guid answerId,
        Guid voterId,
        AnswerVoteType voteType)
    {
        if (_votes.Any(v =>
                v.AnswerId == answerId &&
                v.VoterId == voterId &&
                v.VoteType == voteType) ||
            _votes.Any(v =>
                v.AnswerId == answerId &&
                v.VoterId == voterId &&
                (int)v.VoteType == -(int)voteType))
        {
            return this;
        }

        _votes.Add(new AnswerVote(answerId, voterId, voteType));

        return this;
    }
}