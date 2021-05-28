using System;

namespace Studentmanager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of students");
            var studentcount = int.Parse(Console.ReadLine());

            var studentgrades = new int[studentcount];
            var studentnames = new String[studentcount];

            for (int i = 0; i < studentcount; i++)
            {
                Console.Write("Enter Name of student: ");
                studentnames[i] = Console.ReadLine();

                Console.Write("Enter Grades of student: ");
                studentgrades[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine("Name of student: {0}, Grade: {1}", studentnames[i], studentgrades[i]);
            }
        }
    }
}
