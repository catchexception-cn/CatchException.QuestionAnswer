namespace CatchException.QuestionAnswer.Answers;

public record AnswerSnapshot
{
    public Guid AnswerId { get; init; }

    public DateTime LastModificationTime { get; init; }

    public string Text { get; init; } = default!;

    protected AnswerSnapshot()
    {

    }

    internal AnswerSnapshot(
        Guid answerId,
        DateTime lastModificationTime,
        string text)
    {
        AnswerId = answerId;
        LastModificationTime = lastModificationTime;
        Text = text;
    }
}