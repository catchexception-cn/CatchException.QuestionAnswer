using System;
using System.Collections.Generic;
using System.Text;

namespace CatchException.QuestionAnswer.Answerers
{
    public class CreateAnswersDto
    {
        public Guid QuestionId { get; set; }

        public string Text { get; set; } = default!;

    }
}
