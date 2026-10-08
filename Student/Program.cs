using System.Xml.Linq;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the student name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the student age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student grade");
            double grade = double.Parse(Console.ReadLine());
            Students student = new Students(name, age, grade);
            Console.WriteLine(student.ToString());
        }
    }
}
