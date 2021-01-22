using System;

namespace GreetingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet();
        }

        private static void Greet()
        {
            string[] data = GetData();
            string name = data[0];
            string age = data[1];
            string futureAge = GetAgeInXYears(age, 10);

            Greeting(name, age, futureAge);
        }

        private static void Greeting(string name, string age, string futureAge)
        {
            Console.WriteLine($"Hello {name}, you are {age} years old!");
            Console.WriteLine($"In ten years you will be {futureAge}.");
        }

        private static string[] GetData()
        {
            Console.WriteLine("What is your name and age? ");
            string[] input = Console.ReadLine().Split(' ');

            // Check that two values are entered
            while (input.Length != 2)
            {
                Console.WriteLine("Please use the following format, name then age seperated by only one space: 'name' 'age' ");
                input = GetData();
            }
            // check that age in a number
            while (!CheckAge(input[1]))
            {
                Console.WriteLine("Age must be a number. Please use the following format, name then age seperated by only one space: 'name' 'age' ");
                input = GetData();
            }

            return input;
        }

        private static bool CheckAge(string age)
        {
            try
            {
                Int32.Parse(age);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static string GetAgeInXYears(string age, int years)
        {
            int parsedAge = Int32.Parse(age);

            return (parsedAge + years).ToString();
        }
    }
}