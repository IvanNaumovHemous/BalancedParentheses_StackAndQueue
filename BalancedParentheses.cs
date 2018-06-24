using System;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine();
            var correctString = GetCorrectString(data);
            PrintCorrectAnswer(correctString, data);
                       
        }

        private static void PrintCorrectAnswer(string correctString, string data)
        {
            var temp = correctString.Equals(data) ? "YES" : "NO";
            Console.WriteLine(temp);
        }

        private static string GetCorrectString(string data)
        {           
            string tempLeft = "";
            string tempRight = "";

            for (int i = 0; i < data.Length / 2; i++)
            {
                var input = data[i];
                tempLeft += input;

                switch (input)
                {
                    case '{': tempRight += '}'; break;
                    case '[': tempRight += ']'; break;
                    case '(': tempRight += ')'; break;
                }
            }

            for (int i = tempRight.Length - 1; i >= 0; i--)
            {
                tempLeft += tempRight[i];
            }

            return tempLeft;
        }
    }
}
