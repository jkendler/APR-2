using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vornamen =
            {
                "Max", "Elfriede", "Josef", "Paul"
            };

            for (int i = 0; i < vornamen.Length; i++)
            {
                Console.WriteLine(vornamen[i]);
            }

            Console.WriteLine("while: ");
            int counter = 0;
            while (counter < vornamen.Length)
            {
                Console.WriteLine(vornamen[counter]);
                counter++;
            }

            Console.WriteLine("foreach: ");
            foreach (var vorname in vornamen)
            {
                Console.WriteLine(vorname);
            }

            Random r = new Random();
            int zahl = r.Next(1, 10);

            int[] zahlen = { 3, 5, 7 };
            int summe = 0;

            for (int i = 0; i < 3; i++)
            {
                
                summe = summe + zahlen[i];
               
            }

            Console.WriteLine("Summe: {0}", summe);


            int pos = Array.IndexOf(zahlen, 7);

            Console.WriteLine(pos);



            Console.ReadLine();
        }
    }
}
