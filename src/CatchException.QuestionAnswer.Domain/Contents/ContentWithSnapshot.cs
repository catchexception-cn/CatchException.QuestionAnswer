using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace CatchException.QuestionAnswer.Contents;

public abstract class ContentWithSnapshot : FullAuditedAggregateRoot<Guid>
{
    public string Content { get; protected set; } = default!;

    public ICollection<ContentSnapshot> Snapshots { get; protected set; }

    protected ContentWithSnapshot()
    {
        Snapshots = new List<ContentSnapshot>();
    }

    protected ContentWithSnapshot(Guid id) : base(id)
    {
        Snapshots = new List<ContentSnapshot>();
    }

    protected virtual void SetContent(string content)
    {
        Content = Check.NotNullOrWhiteSpace(content, nameof(content), ContentConsts.MaxContentLength);
    }

    protected virtual ContentWithSnapshot Edit(
        DateTime lastModificationTime,
        string content)
    {
        Snapshots.Add(new ContentSnapshot(
            LastModificationTime ?? CreationTime,
            Content,
            content));

        SetContent(content);
        return this;
    }
}