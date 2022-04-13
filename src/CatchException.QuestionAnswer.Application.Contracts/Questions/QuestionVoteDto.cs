using System;
using System.Collections.Generic;
using System.Text;

namespace CatchException.QuestionAnswer.Questions
{
    public class QuestionVoteDto
    {
        public Guid VoterId { get; set; }

        public QuestionVoteType VoteType { get; set; }
    }
}
