using CatchException.QuestionAnswer.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace CatchException.QuestionAnswer.Answerers
{
    public class AnswersDto : FullAuditedEntityDto<Guid>
    {
        public Guid QuestionId { get;  set; }

        public string Text { get;  set; } = default!;

    }
}
