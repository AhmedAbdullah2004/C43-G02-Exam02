using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class PracticeExam : Exam
    {
        public PracticeExam(int time, int numQuestions) : base(time, numQuestions) { }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                question.ShowQuestion();
                Console.WriteLine($"Correct Answer: {question.RightAnswer.AnswerText}");
            }
        }
    }
}
