using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class Program
    {
        static void Main()
        {
            while (true)
            {
                int inputNumber = GetInputFromUser();
                if (inputNumber == 0)//User input was Exit
                    return;

                var factorList = GetPrimeFactorList(inputNumber);

                PrintFactorList(inputNumber, factorList);
            }

        }

        public static int GetInputFromUser()
        {
            int number = 0;
            do
            {
                Console.WriteLine($"Input number from 1 to {int.MaxValue}:" +
                    $"\nOr Input E to Exit:");
                string input = Console.ReadLine().ToUpper();
                if (input == "E")
                    break;

                int.TryParse(input, out number);
            } while (number < 1 || number > int.MaxValue);

            return number;
        }

        public static List<int> GetPrimeFactorList(int number)
        {
            var factorList = new List<int>();

            if (number != 1)
            {
                for (int multiplayer = 2; number > 1; multiplayer++)
                {
                    while (number % multiplayer == 0)
                    {
                        factorList.Add(multiplayer);
                        number = number / multiplayer;
                    }
                }
            }
            else if (number == 1)
                factorList.Add(1);

            return factorList;
        }

        public static void PrintFactorList(int number, List<int> factors)
        {

            Console.Write($"Prime factors of {number} are: ");

            for (int i = 0; i < factors.Count - 1; i++)
            {
                Console.Write(factors[i] + " x ");
            }

            Console.WriteLine($"{factors[factors.Count - 1]}\n");

        }
    }
}
