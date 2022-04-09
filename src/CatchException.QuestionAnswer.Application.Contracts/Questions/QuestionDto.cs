using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CatchException.QuestionAnswer.Questions
{
    public class QuestionDto : FullAuditedEntityDto<Guid>
    {
        public string Title { get; set; } = default!;

        public string Description { get; set; } = default!;

        public bool IsResolved { get; set; } = false;


        public List<QuestionTagDto> Tags { get; set; } = new List<QuestionTagDto>();

        public List<QuestionVoteDto> Votes { get; set; } = new List<QuestionVoteDto>();

    }
}
