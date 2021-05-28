using System;

namespace Survey
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;
        public string Address;
        public int Experience;

        public void display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your agee is: {0}", Age);
            Console.WriteLine("Your month is: {0}", Month);
            Console.WriteLine("Your month is: {0}", Address);
            Console.WriteLine("Your month is: {0}", Experience);

            switch (Experience)
            {
                case 0: Console.WriteLine("You are a fresher");
                    break;
                case 1:
                    Console.WriteLine("You are a junior");
                    break;
                case 2:
                    Console.WriteLine("You are a Manager");
                    break;
                default: Console.WriteLine("You are a Manager");
                    break;
            }
        }
    }
    
    class Program 
    {
        static void Main(string[] args)
        {
            var data = new Data();
            Console.WriteLine("What is your name");
            data.Name = tryagain();
           
            Console.WriteLine("What is your age");
            data.Age = int.Parse(tryagain());

            Console.WriteLine("What month were you born in");
            data.Month = tryagain();
            
            Console.WriteLine("What's your address");
            data.Address = tryagain();

            Console.WriteLine("What's your job experince");
            data.Experience = int.Parse(tryagain());

            data.display();

        static string tryagain() { 
            var tryagain = Console.ReadLine();
                if (tryagain == "")
                { 
                    Console.WriteLine("You didn't type anything , so try again");
                    return Console.ReadLine();
                }
                else
                    return tryagain;
            }
        }
    }

}