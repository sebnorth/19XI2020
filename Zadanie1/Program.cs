using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {

        static int PodwojPierwszyElement(int[] x) {

            return 2 * x[0];
        }

        static int PodwojElement(int[] x, int indeks) {

            return 2 * x[indeks];
        
        }
        
        static void Main(string[] args)
        {
            int[] tablica = new int[4] { -1,-10,-100, -1000};
            // Console.WriteLine(tablica[0]);
            // Console.WriteLine(tablica);

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    tablica[i] = int.Parse(Console.ReadLine());
            //}


            // Console.WriteLine(PodwojPierwszyElement(tablica));

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("{0} ",PodwojElement(tablica, i));
            }
            
            foreach (int item in tablica)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }
    }
}
