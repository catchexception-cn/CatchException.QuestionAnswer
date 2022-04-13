using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace CatchException.QuestionAnswer.Answerers
{
    public interface IAnswersAppService : IApplicationService
    {
        Task CreateAsync(CreateAnswersDto input);
        Task UpdateAsync(UpdateAnswersDto id);
        Task DeleteAsync(Guid id);

    }
}
