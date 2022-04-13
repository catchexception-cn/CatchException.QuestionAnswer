using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Comments;

public class Comment : FullAuditedAggregateRoot<Guid>
{
    public Guid? RepliedCommentId { get; protected set; }

    public string Text { get; protected set; } = default!;

    protected Comment()
    {

    }

    public Comment(
        Guid id,
        Guid? repliedCommentId,
        string text)
        : base(id)
    {
        RepliedCommentId = repliedCommentId;
        Text = Check.NotNullOrWhiteSpace(text, nameof(text), CommentConsts.MaxTextLength);
    }
}
