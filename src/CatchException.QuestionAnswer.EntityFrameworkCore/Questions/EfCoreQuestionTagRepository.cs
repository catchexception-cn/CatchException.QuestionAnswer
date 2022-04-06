using CatchException.QuestionAnswer.EntityFrameworkCore;

using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace CatchException.QuestionAnswer.Questions;

public class EfCoreQuestionTagRepository : EfCoreRepository<IQuestionAnswerDbContext, QuestionTag, Guid>, IQuestionTagRepository
{
    public EfCoreQuestionTagRepository(IDbContextProvider<IQuestionAnswerDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public Task<List<QuestionTag>> GetByNameAsync(string name, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }
}