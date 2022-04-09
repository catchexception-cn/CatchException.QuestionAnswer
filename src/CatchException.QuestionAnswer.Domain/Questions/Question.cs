using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Questions;

public class Question : FullAuditedAggregateRoot<Guid>
{
    public string Title { get; protected set; } = default!;

    public string Description { get; protected set; } = default!;

    public bool IsResolved { get; protected set; }
    

    private readonly List<QuestionVote> _votes;
    public virtual IReadOnlyCollection<QuestionVote> Votes => _votes;

    private readonly List<QuestionComment> _comments;
    public virtual IReadOnlyCollection<QuestionComment> Comments => _comments;

    private readonly List<QuestionQuestionTag> _tags;
    public virtual IReadOnlyCollection<QuestionQuestionTag> Tags => _tags;


    protected Question()
    {
        _votes = new List<QuestionVote>();
        _tags = new List<QuestionQuestionTag>();
    }
}