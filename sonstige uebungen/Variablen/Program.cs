using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variablen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo im neuen Schuljahr");
            var vorname = "Julia";

            Console.WriteLine("Vorname: {0}",vorname);

            var zahl = 12;
            Console.WriteLine("Zahl: {0}",zahl);

            Console.WriteLine($"Hallo {vorname} {zahl}");

            Console.Write("Ihr Nachname: ");
            string nachname = Console.ReadLine();
            Console.WriteLine($"Nachname: {nachname}");

            Console.Write("Geben Sie den Brutto Betrag ein: ");
            double betrag = Convert.ToDouble(Console.ReadLine());
            double netto = betrag / (1 + 20 / 100);
            Console.WriteLine("Netto {0}", netto);


            

            
        }
    }
}
