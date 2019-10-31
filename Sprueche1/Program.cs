using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprueche1
{
    class Program
    {
        static void Main(string[] args)
        {
            Spruch s = new Spruch();

            Console.WriteLine(s.Next());
            Console.WriteLine(s.Next());
            Console.WriteLine(s.Next());
            Console.WriteLine(s.Next());
        }
    }

    class Spruch
    {
        string[] sprueche = new string[3];
        int zaehler = 0;
        public Spruch()
        {
            sprueche[0] = "Der frühe Vogel fängt den Wurm";
            sprueche[1] = "Was Hänschen...";
            sprueche[2] = "Morgenstund hat...";
        }

        public string Next()
        {
            if (zaehler == sprueche.Length)
            {
                zaehler =  0;
            }
            string s = sprueche[zaehler];
            zaehler++;

            return s;


            
        }
    }

}
