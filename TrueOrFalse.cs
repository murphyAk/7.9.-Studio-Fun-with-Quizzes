using System;
using System.Collections.Generic;
using System.Text;

namespace _7._9._Studio_Fun_with_Quizzes
{
    public class TrueOrFalse : Question
    {
        private bool CorrectAnswer { get; set; }

        public TrueOrFalse(string text, int pointValue, bool correctAnswer) : base(text, pointValue)
        {
            CorrectAnswer = correctAnswer;
        }

        public override void DisplayAnswers()
        {
            Console.WriteLine("True / False");
        }

        public override int GetAnswers()
        {
            Console.WriteLine("Enter 't'/'T' for True, 'f'/'F' for False :");

            string userAnswer = Console.ReadLine().ToLower();

            if (userAnswer == "t")
            {
                if (CorrectAnswer == true)
                {
                    return 1;
                }
                return 0;
            }

            if (userAnswer == "f")
            {
                if (CorrectAnswer == false)
                {
                    return 1;
                }
                return 0;
            }

            return 0;
        }
    }
}
