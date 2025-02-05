using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Exam = new FinalExam(60, 2);
            Exam.Questions.Add(new True_or_false("C# is an Object-Oriented language?", 5));
            Exam.Questions.Add(new MCQ("What is the main method in C#?", 5,
                new List<Answer>
                {
                    new Answer(1, "start()"),
                    new Answer(2, "execute()"),
                    new Answer(3, "Main()")
                }, new Answer(3, "Main()")));
        }
    }
}
