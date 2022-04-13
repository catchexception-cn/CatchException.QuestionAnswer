namespace CatchException.QuestionAnswer.Answers;

public record AnswerVote(Guid AnswerId, Guid VoterId, AnswerVoteType VoteType);