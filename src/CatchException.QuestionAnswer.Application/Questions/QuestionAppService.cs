using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CatchException.QuestionAnswer.Questions
{
    public class QuestionAppService : QuestionAnswerAppService, IQuestionAppService
    {

        public Task<QuestionWithDetailsDto> CreateAsync(CreateQuestionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<QuestionWithDetailsDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<QuestionDto>> GetListAsync(PagedResultRequestDto input)
        {
            throw new NotImplementedException();
        }

        public Task<QuestionWithDetailsDto> UpdateAsync(UpdateQuestionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<QuestionWithDetailsDto> CloseAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
