using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchException.QuestionAnswer.Questions
{
    public class QuestionTagDto
    {

        public Guid TagId { get; set; }
        public string Name { get; protected set; } = default!;
        public string Description { get; protected set; } = default!;


    }
}
