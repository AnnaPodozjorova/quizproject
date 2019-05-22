using System;
using TestApp.Domain.Entities;

namespace TestApp.Domain.Entities
{
    public class QuestionQuiz
    {
        public int QuestionQuizId { get; set; }
        public int QuestionsId { get; set; }
        public Question Question { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
