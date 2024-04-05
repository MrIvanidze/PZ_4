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
        }
    }
}