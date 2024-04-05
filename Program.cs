using System;
using System.Globalization;
using System.Linq;

namespace PZ_4_N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] RandomArray = new int[36];
            Random random = new Random();
            int[] PairArray = { };

            for (int i = 0; i < RandomArray.Length; i++)
            {
                RandomArray[i] = random.Next(0, 50);

                if (RandomArray[i] % 2 == 0)
                {
                    PairArray = PairArray.Append(RandomArray[i]).ToArray();
                }
            }

            Console.WriteLine($"Arrays include {PairArray.Length} pair numbers.");
            Console.Write("It's: ");

            for (int i = 0; i < PairArray.Length - 1; i++)
            {
                Console.Write($"{PairArray[i]}, ");
            }

            Console.Write($"{PairArray[^1]}.");

        }
    }
}