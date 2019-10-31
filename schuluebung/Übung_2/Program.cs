using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 231;

            string zahl1 = Convert.ToString(zahl);

            int erg = 0;

            for (int i = 0; i < zahl1.Length; i++)
            {

                string teil = zahl1.Substring(i, 1);

                int teil1 = Convert.ToInt32(teil);

                erg = erg + teil1;



            }

            int erg1 = erg / 3;

            Console.WriteLine("Quersumme: {0}",erg);

            
            Console.WriteLine(erg1);

            Console.ReadLine();
            

        }
    }
}
