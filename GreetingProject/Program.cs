using System;

namespace GreetingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet();
        }

        private static string[] GetData()
        {
            Console.WriteLine("What is your name and age? ");
            string[] input = Console.ReadLine().Split(' ');

            // make sure user enters two values seperated by one space
            while (input.Length != 2)
            {
                Console.WriteLine("Please use the following format, name then age seperated by only one space: 'name' 'age' ");
                GetData();
            }
            // check if age is an integer
            if (!CheckAge(input[1])) 
            {
                Console.WriteLine("Age must be a number");
                Console.WriteLine("Please use the following format, name then age seperated by only one space: 'name' 'age' ");
                GetData();
            }
            return input;
        }

        private static bool CheckAge(string age)
        {
            if (Int32.Parse(age).GetType() == typeof(int))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GetAgeInXYears(string age, int years)
        {
            int parsedAge = Int32.Parse(age);
            
            return (parsedAge + years).ToString();
        }

        private static void Greet()
        {
            string[] data = GetData();
            string name = data[0];
            string age = data[1];
            string futureAge = GetAgeInXYears(data[1], 10);

            Greeting(name, age, futureAge);
        }

        private static void Greeting(string name, string age, string futureAge)
        {
            Console.WriteLine($"Hello {name}, you are {age} years old!");
            Console.WriteLine($"In ten years you will be {futureAge}.");
        }
    }
}
