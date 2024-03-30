using System;

namespace _05.Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz = Console.ReadLine();

            foreach (char bukva in niz.ToCharArray())
            {
                Console.WriteLine(bukva);
            }
        }
    }
}
