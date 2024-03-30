using System;

namespace _06.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = Console.ReadLine();

            int suma = 0;

            for (int i = 0; i < duma.Length; i++)
            {
                char bukva = duma[i];

                switch (bukva)
                {
                    case 'a':
                        suma += 1;
                        break;
                    case 'e':
                        suma += 2;
                        break;
                    case 'i':
                        suma += 3;
                        break;
                    case 'o':
                        suma += 4;
                        break;
                    case 'u':
                        suma += 5;
                        break;

                }
            }

            Console.WriteLine(suma);

        }
    }
}
