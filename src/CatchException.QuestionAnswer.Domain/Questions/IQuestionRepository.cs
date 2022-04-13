using Volo.Abp.Domain.Repositories;

namespace CatchException.QuestionAnswer.Questions;

public interface IQuestionRepository : IRepository<Question, Guid>
{

}