﻿namespace CatchException.QuestionAnswer;

public static class QuestionAnswerDbProperties
{
    public static string DbTablePrefix { get; set; } = "QuestionAnswer";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "QuestionAnswer";
}