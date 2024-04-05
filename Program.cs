namespace PZ_4_N4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(i + 'a');
            }
            foreach (char i in alphabet)
            {
                Console.WriteLine($"Letter - {i}. In the ASCII table it's: {(int)i}");
            }
        }
    }
}