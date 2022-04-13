using CatchException.QuestionAnswer.Answerers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchException.QuestionAnswer.Answers
{
    public class AnswersAppService : QuestionAnswerAppService, IAnswersAppService
    {

        protected AnswerManager AnswerManager => LazyServiceProvider.LazyGetRequiredService<AnswerManager>();

        public Task CreateAsync(CreateAnswersDto input)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateAnswersDto id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
