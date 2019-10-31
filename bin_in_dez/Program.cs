using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bin_in_dez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine Binärzahl ein: ");
            string eingabe = Console.ReadLine();

            double sum = 0;
            for (int i = 0; i <eingabe.Length; i++)
            {
                string zk = eingabe.Substring(i, 1);
                int z = Convert.ToInt32(zk);

                int e = eingabe.Length - 1 - i;

                double erg = z * Math.Pow(2, e);

                sum = sum + erg;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
