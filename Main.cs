using System.Diagnostics;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Sub1 = new Subject(10, "C#");
            Sub1.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start The Exam (y | n): ");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch SW = new Stopwatch();
                SW.Start();
                Sub1.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");
            }
        }
    }
}
