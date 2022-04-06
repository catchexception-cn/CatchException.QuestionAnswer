using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Comments;

public class Comment : FullAuditedAggregateRoot<Guid>
{
    public RepliedType RepliedType { get; protected set; }

    public Guid RepliedToId { get; protected set; }

    public string Text { get; protected set; } = default!;

    protected Comment()
    {

    }

    public Comment(
        Guid id,
        RepliedType repliedType,
        Guid repliedToId,
        string text)
        : base(id)
    {
        RepliedType = repliedType;
        RepliedToId = repliedToId;
        Text = Check.NotNullOrWhiteSpace(text, nameof(text), CommentConsts.MaxTextLength);
    }
}
