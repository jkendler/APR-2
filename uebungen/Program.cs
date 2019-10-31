using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebungen
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 5 * 1 = 5
             * 5 * 2 = 10
             * 10 * 3 = 30
             * 30 * 4 = 120
             * 120 * 5 = 600
             * 600 * 6 = 3600
             * 3600 * 7 = 25200
             * 25200 * 8 = 201600
             * ...
             */

            long zahl = 5;

            for (int i = 1; i < 10; i++)
            {
                // mit folgenden i wird
                //die Schleife ausgeführt
                //1, 2, 3, 4, 5, 6, 7, 8, 9

                long erg = zahl * i;
                Console.WriteLine("{0} * {1} = {2}",zahl,i,erg);

                zahl = erg;

                
            }
            for (int i = 1; i < 10; i++)
            {

                long erg = zahl / i;
                Console.WriteLine("{0} / {1} = {2}", zahl, i, erg);

                zahl = erg;


            }


            string vorname = default;

            int nummer = default;

            Console.WriteLine(vorname);

            Console.WriteLine(nummer);

        }
    }
}
