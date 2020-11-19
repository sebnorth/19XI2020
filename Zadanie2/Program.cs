using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {

        static bool FirstLast6(int[] x) {

            if (x[0] == 6 || x[x.Length - 1] == 6) return true;
            else return false;
        }
        
        static void Main(string[] args)
        {
            int[] tablica = new int[3] { 1, 2, 6 };
            Console.WriteLine(FirstLast6(tablica));

            Console.WriteLine(FirstLast6(new int[] { 6,1,2,3}));
            Console.WriteLine(FirstLast6(new int[] { 13, 6, 1, 2, 3 }));
            Console.ReadKey();
        }
    }
}
