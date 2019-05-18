using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApplication.Classes
{
    public struct QuestionVariant
    {
        public readonly string Text;
        public readonly bool IsCorrect;

        public QuestionVariant(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }
}
