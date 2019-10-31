using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nettobrutto
{
    class Program
    {
        static double nettoZuBrutto(double netto, double steuer)
        {
            double brutto = netto + netto / 100 * steuer;
            return brutto;
        }
        static void Main(string[] args)
        {
            Console.Write("Netto: ");
            double netto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Steuersatz: ");
            double steuer = Convert.ToDouble(Console.ReadLine());

            double brutto = nettoZuBrutto(netto, steuer);


            brutto = nettoZuBrutto(500, 20);
            //netto * (1 + steuer/100)
            Console.WriteLine("Brutto: {0}",brutto);
        }
    }
}
