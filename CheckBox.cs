using System;
using System.Collections.Generic;
using System.Text;

namespace _7._9._Studio_Fun_with_Quizzes
{
    public class CheckBox : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private List<int> CorrectAnswers { get; set; }

        public CheckBox(string text, int pointValue, List<string> possibleAnswers, List<int> correctAnswers) : base(text, pointValue)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
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
            List<int> userAnswers = new List<int>();
            string userInput;


            Console.WriteLine("This question could have multiple correct answers (Write the answer number or ENTER stop)");

            do
            {
                Console.WriteLine("Your Answer: ");
                userInput = Console.ReadLine();

                if (userInput != "")
                {
                    userAnswers.Add(Int32.Parse(userInput));
                }

            } while (userInput != "" && userAnswers.Count <= CorrectAnswers.Count);

            int answeredCorrectly = CheckAnswers(userAnswers);

            return answeredCorrectly;
        }


        private int CheckAnswers(List<int> userAnswers)
        {
            int answeredCorrectly = 0;

            foreach (int answer in userAnswers)
            {
                if (CorrectAnswers.Contains(answer))
                {
                    answeredCorrectly++;
                }
            }

            return answeredCorrectly;
        }
    }
}
