using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto vw = new Auto();
            vw.oeffneSchiebedach();
            vw.schliesseeSchiebedach();
            vw.oeffneSchiebedach();
            vw.schliesseeSchiebedach();
            vw.oeffneSchiebedach();

            Console.WriteLine("Anzahl der Bewegungen des Schiebedaches: {0}",vw.Status);
        }

        class Auto
        {
            bool isOpen;
            long counter = 0;
            public Auto()
            {
                isOpen = false;
            }

            public void oeffneSchiebedach()
            {
                isOpen = true;
                counter++;
            }
            public void schliesseeSchiebedach()
            {
                isOpen = false;
                counter++;
            }

            public long Status => counter;
        }
    }
}
