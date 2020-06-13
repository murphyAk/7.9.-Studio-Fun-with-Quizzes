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
}
  
