﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Domain.Entities
{
    public class Quiz
    {
        public Quiz()
        {
            QuestionQuiz = new HashSet<QuestionQuiz>();
            QuizUser = new HashSet<QuizUser>();
        }

        public int QuizId { get; set; }
        public string Title { get; set; }
        public int number { get; set; }
        public ICollection<QuestionQuiz> QuestionQuiz { get; set; }
        public ICollection<QuizUser> QuizUser { get; set; }
    }
}
