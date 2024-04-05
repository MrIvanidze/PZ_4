using System.Xml.Linq;

namespace PZ_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[50];
            int count = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                count += 2;
                elements[i] = count;
            }

            foreach (int element in elements)
            {
                Console.WriteLine($"Element: {element}");
            }


        }
    }
}