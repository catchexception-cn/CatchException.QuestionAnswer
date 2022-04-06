using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Comments;

public class Comment : FullAuditedAggregateRoot<Guid>
{
    public CommentType CommentType { get; protected set; }

    public Guid PostId { get; protected set; }

    public Guid? RepliedCommentId { get; protected set; }

    public string Text { get; protected set; } = default!;

    protected Comment()
    {

    }

    public Comment(
        Guid id,
        CommentType commentType,
        Guid postId,
        Guid? repliedCommentId,
        string text)
        : base(id)
    {
        CommentType = commentType;
        PostId = postId;
        RepliedCommentId = repliedCommentId;
        Text = Check.NotNullOrWhiteSpace(text, nameof(text), CommentConsts.MaxTextLength);
    }
}
