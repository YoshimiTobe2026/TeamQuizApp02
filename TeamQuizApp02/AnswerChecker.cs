using System;
using System.Collections.Generic;
using System.Text;

namespace TeamQuizApp02
{
    internal class AnswerChecker
    {
        public bool CheckAnswer(Question q, int selectedIndex)
        {
            return q.CorrectIndex == selectedIndex;
        }
    }
}
