using Volo.Abp.Domain.Entities;

namespace CatchException.QuestionAnswer.Contents;

public class ContentSnapshot : Entity<Guid>
{
    public DateTime LastModificationTime { get; init; }

    public string Snapshot { get; init; } = default!;

    public string CurrentContent { get; init; } = default!;

    protected ContentSnapshot()
    {

    }

    public ContentSnapshot(
        DateTime lastModificationTime,
        string snapshot,
        string currentContent)
    {
        LastModificationTime = lastModificationTime;
        Snapshot = snapshot;
        CurrentContent = currentContent;
    }

}