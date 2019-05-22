using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class AsnwerQuestionQuizUser
    {
        public int AsnwerQuestionQuizUserId { get; set; }
        public int QuizUserId { get; set; }
        public QuizUser QuizUser { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
    }
}
