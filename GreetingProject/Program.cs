using System;

namespace GreetingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
        }

        private static string[] GetData()
        {
            Console.WriteLine("What is your name and age? ");
            string[] data = Console.ReadLine().Split(' ');
            
            return data;
        }

        private static string GetAgeInXYears(string age, int years)
        {
            int parsedAge = Int32.Parse(age);
            return (parsedAge + years).ToString();
        }

        private static void Greeting()
        {
            string[] data = GetData();
            string name = data[0];
            string age = data[1];
            string ageInTen = GetAgeInXYears(data[1], 10);

            Console.WriteLine($"Hello {name}, you are {age} years old!");
            Console.WriteLine($"In ten years you will be {ageInTen}.");
        }
    }
}
