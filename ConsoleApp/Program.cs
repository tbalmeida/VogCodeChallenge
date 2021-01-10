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

            object myVarObj = 6;
            Console.WriteLine( $"Step 7\n\nTESTModule returns '{TESTModule(myVarObj)}' when receiving '{myVarObj}'."  );
        }

        static object TESTModule(object inputPar)
        {
            var myType = inputPar.GetType();
            object result = null;
            switch (inputPar)
            {
                case int n when (n < 1):
                    throw new Exception("Numeric input should be higher than 1");

                case int n when (n >= 1 && n <= 4):
                    result = n * 2;
                    break;

                case int n when (n > 4):
                    result = n * 3;
                    break;

                case float n when (n == 1.0f || n == 2.0f):
                    result = 3.0f;
                    break;

                case string s:
                    result = s.ToUpper();
                    break;

                default:
                    result = inputPar;
                    break;
            }

            return result;
        }
    }
}
