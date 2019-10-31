using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._09._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie ihren Vornamen ein: ");
            string wort = Console.ReadLine();

            string ausgabe = wort.Length + wort.Substring(1, wort.Length - 1);
            Console.WriteLine(" ausgabe {0}",ausgabe);

            Console.ReadLine();

        }
    }
}
