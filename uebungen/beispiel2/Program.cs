using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beispiel2
{
    class Program
    {
        static void Main(string[] args)
        {

            int zahl = 231;

            string zahl1 = Convert.ToString(zahl);

            int quersumme = 0;

            for (int i = 0; i < zahl1.Length; i++)
            {

                string teil = zahl1.Substring(i, 1);

                int ziffer = Convert.ToInt32(teil);

                quersumme = quersumme + ziffer;



            }

            if(quersumme % 3 == 0)
            {
                Console.WriteLine($"Die Zahl {zahl} ist " + $"durch 3 ohne Rest teilbar");
            }
            else
            {
                Console.WriteLine($"Die Zahl {zahl} ist " + $"durch 3 nicht ohne Rest teilbar");
            }


        }
    }
}
