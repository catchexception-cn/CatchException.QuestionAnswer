using Volo.Abp.Domain.Repositories;

namespace CatchException.QuestionAnswer.Answerers;

public interface IAnswererRepository : IRepository<Answerer, Guid>
{

}