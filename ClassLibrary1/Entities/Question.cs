using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class Question
    {
        public Question()
        {
            QuestionQuiz = new HashSet<QuestionQuiz>();
            Answers = new HashSet<Answer>();
            AsnwerQuestionQuizUsers = new HashSet<AsnwerQuestionQuizUser>();
        }

        public int QuestionId { get; set; }
        public string Title { get; set; }
        public int QuestionTime { get; set; }
        public ICollection<QuestionQuiz> QuestionQuiz { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public ICollection<AsnwerQuestionQuizUser> AsnwerQuestionQuizUsers { get; set; }
    }
}
