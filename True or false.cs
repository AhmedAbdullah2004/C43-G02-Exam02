using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class True_or_false : Question
    {
        public True_or_false (string body, int mark) : base("True/False", body, mark)
        {
            Answers.Add(new Answer(1, "True"));
            Answers.Add(new Answer(2, "False"));
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}: {Body} (Mark: {Mark})");
            foreach (var ans in Answers)
            {
                Console.WriteLine($"{ans.AnswerId}. {ans.AnswerText}");
            }
        }
    }
}

