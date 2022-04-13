namespace CatchException.QuestionAnswer;

public static class QuestionAnswerDbProperties
{
    public static string DbTablePrefix { get; set; } = "Qa";

    public static string DbSchema { get; set; } = default!;

    public const string ConnectionStringName = "QuestionAnswer";
}
