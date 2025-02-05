using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class MCQ : Question
    {
        public List<Answer> Answers { get; set; }
        public Answer RightAnswer { get; set; }

        public MCQ(string body, int mark, List<Answer> choices, Answer correctAnswer)
            : base("MCQ", body, mark) 
        {
            Answers = choices;
            RightAnswer = correctAnswer;
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
