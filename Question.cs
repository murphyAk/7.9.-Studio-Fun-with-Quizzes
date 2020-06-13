using System;
using System.Collections.Generic;
using System.Text;

namespace _7._9._Studio_Fun_with_Quizzes
{
    public abstract class Question
    {
        public string Text { get; set; }
        public int PointValue { get; set; }

        protected Question(string text, int pointValue)
        {
            Text = text;
            PointValue = pointValue;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(Text);
        }

        public abstract void DisplayAnswers();

        public abstract int GetAnswers();
    }

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

            if(userAnswer == "t")
            {
                if(CorrectAnswer == true)
                {
                    return 1;
                }
                return 0;
            }

            if(userAnswer == "f")
            {
                if(CorrectAnswer == false)
                {
                    return 1;
                }
                return 0;
            }

            return 0;
        }
    }
}
