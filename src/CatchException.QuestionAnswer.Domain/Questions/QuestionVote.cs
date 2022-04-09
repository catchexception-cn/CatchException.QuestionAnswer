namespace CatchException.QuestionAnswer.Questions;

public record QuestionVote(Guid QuestionId, Guid VoterId, QuestionVoteType VoteType);
