using System.Diagnostics.Metrics;

namespace PZ_4_N3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("You want to know the length of your text? No problem! \n" +
                "Enter your text here: ");
            string text = Console.ReadLine();

            Console.WriteLine($"Text “{text}” include: {text.Length} symbols");

            Console.Write("Do you want to know how many times a certain symbol hits? Okay, what symbol do you want to find? \n" +
                "Write it here: ");
            char symbol = char.Parse(Console.ReadLine());

            int score = 0;

            foreach (char i in text)
            {
                if (i == symbol)
                {
                    score++;
                }
            }

            if (score > 1)
            {
                Console.WriteLine($"I found this symbol {score} times.");
            }
            else if (score == 1)
            {
                Console.WriteLine($"I found this symbol {score} time.");
            }
            else
            {
                Console.WriteLine("I didn't find this symbol :(");
            }
        }
    }
}