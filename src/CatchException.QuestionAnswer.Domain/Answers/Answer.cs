using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Answers;

public class Answer : FullAuditedAggregateRoot<Guid>
{
    public virtual Guid QuestionId { get; protected set; }

    public virtual string Text { get; protected set; } = default!;

    private readonly List<AnswerVote> _votes;
    public virtual IReadOnlyCollection<AnswerVote> Votes => _votes;

    private readonly List<AnswerSnapshot> _snapshots;
    public virtual IReadOnlyCollection<AnswerSnapshot> Snapshots => _snapshots;

    protected Answer()
    {
        _votes = new List<AnswerVote>();
        _snapshots = new List<AnswerSnapshot>();
    }

    public Answer(
        Guid id,
        Guid questionId,
        string text) : base(id)
    {
        QuestionId = questionId;
        SetTextInternal(text);

        _votes = new List<AnswerVote>();
        _snapshots = new List<AnswerSnapshot>();
    }

    public Answer Edit(string text)
    {
        _snapshots.Add(new AnswerSnapshot(
            Id,
            LastModificationTime ?? CreationTime,
            text));

        SetTextInternal(text);

        return this;
    }

    internal Answer Vote(
        Guid answerId,
        Guid voterId,
        AnswerVoteType voteType)
    {
        if (_votes.Any(v =>
                v.AnswerId == answerId &&
                v.VoterId == voterId &&
                v.VoteType == voteType))
        {
            throw new UserFriendlyException("");
        }
        if (_votes.Any(v =>
                v.AnswerId == answerId &&
                v.VoterId == voterId &&
                (int)v.VoteType == -(int)voteType))
        {
            throw new UserFriendlyException("");
        }

        _votes.Add(new AnswerVote(answerId, voterId, voteType));

        return this;
    }

    private void SetTextInternal(string text)
    {
        Text = Check.NotNullOrWhiteSpace(text, nameof(text), AnswerConsts.MaxAnswerLength);
    }
}