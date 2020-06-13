using System;
using System.Collections.Generic;
using System.Text;

namespace _7._9._Studio_Fun_with_Quizzes
{
    public class Quiz
    {

        public List<Question> Questions { get; set; }
        public double Score { get; set; }
        private double Total { get; set; }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            Total = 0;

            foreach (Question qs in Questions)
            {
                Total += qs.PointValue;
            }
        }

        public void AddQuestion(Question qs)
        {
            Questions.Add(qs);
            Total += qs.PointValue;
        }

        public void RunQuiz()
        {
            foreach (Question qs in Questions)
            {
                Console.WriteLine("Question: ");
                qs.DisplayQuestion();
                qs.DisplayAnswers();
                double points = qs.GetAnswers();
                Console.WriteLine();


                Score += points;
            }

            Console.WriteLine($"You answered {Score} out of {Total} questions correct. Your grade is {Score/Total * 100}%");
        }


    }
}
