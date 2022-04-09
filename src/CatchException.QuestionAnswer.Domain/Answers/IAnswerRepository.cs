using Volo.Abp.Domain.Repositories;

namespace CatchException.QuestionAnswer.Answers;

public interface IAnswerRepository : IRepository<Answer, Guid>
{

}