using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace CatchException.QuestionAnswer.Questions
{
    public interface IQuestionAppService: IApplicationService
    {
        Task<QuestionWithDetailsDto> GetAsync(Guid id);
        Task<PagedResultDto<QuestionDto>> GetListAsync(PagedResultRequestDto input);
        Task<QuestionWithDetailsDto> CreateAsync(CreateQuestionDto input);
        Task<QuestionWithDetailsDto> UpdateAsync(UpdateQuestionDto input);
        Task<QuestionWithDetailsDto> CloseAsync(Guid id);

    }
}
