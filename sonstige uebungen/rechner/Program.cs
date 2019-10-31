using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rechner
{
    class Program
    {
        static int Mult(int z1, int z2, int z3)
        {
            int erg = z1 * z2 * z3;
            // Console.WriteLine("Ergebnis {0}",erg);
            return erg;
        }

        static void Main(string[] args)
        {
            var erg1 = Mult(2, 3, 4);
            double erg2 = Mult(1, 3, 3) / 2.0;

            Console.WriteLine($"Erg 1: {erg1}");
            Console.WriteLine("Erg 2: {0}", erg2);
        }

    }
}
