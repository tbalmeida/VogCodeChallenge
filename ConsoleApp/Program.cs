using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        public static class QuestionClass
        {
            public static List<string> NamesList = new List<string>()
            {
                "Jimmy",
                "Jeffrey",
                "John",
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vog Code Challenge - Step 5\n");

            byte counter = 0;

            while (counter < QuestionClass.NamesList.Count)
            {
                Console.WriteLine($"Item {counter + 1} - { QuestionClass.NamesList[counter]}");
                counter++;
            }
        }
    }
}
