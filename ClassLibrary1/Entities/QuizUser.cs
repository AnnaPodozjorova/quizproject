using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class QuizUser
    {
        public QuizUser()
        {
            AsnwerQuestionQuizUser = new HashSet<AsnwerQuestionQuizUser>();
        }
        public int QuizUserId { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public DateTime Begin { get; set; }
        public ICollection<AsnwerQuestionQuizUser> AsnwerQuestionQuizUser { get; set; }
    }
}
