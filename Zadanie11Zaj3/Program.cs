using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11Zaj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // i - numer wiersza
            {

                for (int s = 0; s < n-i-1; s++)
                {
                    Console.Write(" ");
                }

                for (int x = 0; x < i+1; x++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
