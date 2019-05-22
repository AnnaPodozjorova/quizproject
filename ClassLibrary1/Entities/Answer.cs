using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public string Title { get; set; }
        public Boolean IsTrue { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
        public ICollection<AsnwerQuestionQuizUser> AsnwerQuestionQuizUsers { get; set; }
}
}
