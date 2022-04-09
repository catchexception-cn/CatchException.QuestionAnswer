using CatchException.QuestionAnswer.Contents;

using Volo.Abp;

namespace CatchException.QuestionAnswer.Questions;

public class Question : ContentWithSnapshot
{
    public string Title { get; protected set; } = default!;

    public bool IsResolved { get; protected set; }

    public bool IsClosed { get; protected set; }

    public Guid? AcceptedAnswerId { get; protected set; }

    private readonly List<QuestionVote> _votes;
    public IReadOnlyCollection<QuestionVote> Votes => _votes;

    private readonly List<QuestionQuestionTag> _tags;
    public IReadOnlyCollection<QuestionQuestionTag> Tags => _tags;

    protected Question()
    {
        _votes = new List<QuestionVote>();
        _tags = new List<QuestionQuestionTag>();
    }

    public Question(
        Guid id,
        string title,
        string content) : base(id)
    {
        Title = Check.NotNullOrWhiteSpace(title, nameof(title), QuestionConsts.MaxTitleLength);
        SetContent(content);

        _votes = new List<QuestionVote>();
        _tags = new List<QuestionQuestionTag>();
    }

    public Question SetTags(Guid[] tagIds)
    {
        _tags.Clear();
        _tags.AddRange(
            tagIds.Select(tagId => new QuestionQuestionTag(Id, tagId)));

        return this;
    }

    public Question Vote(
        Guid questionId,
        Guid voterId,
        QuestionVoteType voteType)
    {
        if (_votes.Any(v =>
                v.QuestionId == questionId &&
                v.VoterId == voterId &&
                v.VoteType == voteType) ||
            _votes.Any(v =>
                v.QuestionId == questionId &&
                v.VoterId == voterId &&
                (int)v.VoteType == -(int)voteType))
        {
            return this;
        }

        _votes.Add(new QuestionVote(questionId, voterId, voteType));

        return this;
    }

    internal Question Solved(Guid acceptedAnswerId)
    {
        if (IsResolved)
        {
            throw new QuestionSolvedException();
        }
        AcceptedAnswerId = acceptedAnswerId;
        IsResolved = true;

        return this;
    }
}