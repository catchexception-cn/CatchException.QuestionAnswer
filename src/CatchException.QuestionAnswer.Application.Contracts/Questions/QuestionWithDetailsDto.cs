using CatchException.QuestionAnswer.Answerers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CatchException.QuestionAnswer.Questions
{
    public class QuestionWithDetailsDto : FullAuditedEntityDto<Guid>
    {
        public string Title { get;  set; } = default!;

        public string Description { get;  set; } = default!;

        public bool IsResolved { get; set; } = false;

        public List<QuestionTagDto> Tags { get; set; } = new List<QuestionTagDto>();

        public List<QuestionVoteDto> Votes { get; set; } = new List<QuestionVoteDto>();

        public List<AnswersDto> Answers { get; set; } = new List<AnswersDto>();

    }
}
