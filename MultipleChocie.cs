using System;
using System.Collections.Generic;
using System.Text;

namespace _7._9._Studio_Fun_with_Quizzes
{
    public class MultipleChoice : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private int CorrectAnswer { get; set; }

        public MultipleChoice(string text, int pointValue, List<string> possibleAnswers, int correctAnswer) : base(text, pointValue)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswer = correctAnswer;
        }

        public override void DisplayAnswers()
        {
            foreach (string possibleAnswer in PossibleAnswers)
            {
                Console.WriteLine(possibleAnswer);
            }
        }

        public override int GetAnswers()
        {
            Console.WriteLine("Enter the number of your answer (e.g. 1 for the first option) :");

            int userAnswer = Int32.Parse(Console.ReadLine());

            if (userAnswer == CorrectAnswer)
            {
                return 1;
            }

            return 0;
        }
    }
}
