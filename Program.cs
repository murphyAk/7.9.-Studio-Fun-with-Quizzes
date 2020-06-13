using System;
using System.Collections.Generic;

namespace _7._9._Studio_Fun_with_Quizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            // build quiz
            Quiz quiz = new Quiz(new List<Question>());

            // build multiple question format
            List<string> firstOptions = new List<string>() { "1", "2", "3", "4",};
            MultipleChoice firstQuestion = new MultipleChoice("2+2?", 1, firstOptions, 4);

            quiz.AddQuestion(firstQuestion);

            // build checkbox format
            List<string> secondOptions = new List<string>() { "1", "2", "3", "4" };
            List<int> answer = new List<int>() { 1, 3 };
            CheckBox secondQuestion = new CheckBox("x+2 = abs(x+2), therefore, x = ?", 2, secondOptions, answer);

            quiz.AddQuestion(secondQuestion);

            // build true false format
            TrueOrFalse thirdQuestion = new TrueOrFalse("this answer is false", 1, false);

            quiz.AddQuestion(thirdQuestion);

            // run quiz
            quiz.RunQuiz();

        }
    }
}
