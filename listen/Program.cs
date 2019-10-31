using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 23;
            List<int> zahlen = new List<int>();
            Random r = new Random();
            List<string> farben = new List<string>()
            {
                "rot","grün",
                "blau","lila"
            };

            farben.Add("schwarz");

            farben.Remove("grün");

            farben.RemoveAt(0);

            farben.Insert(0, "gelb");

            for (int i = 0; i < farben.Count; i++)
            {
                Console.WriteLine(farben[i]);
                Console.WriteLine(farben.ElementAt(i));
            }


            foreach (var farbe in farben)
            {
                Console.WriteLine(farbe);
            }

            int counter = 0;
            while(counter > 0)
            {
                Console.WriteLine("Hallo, Welt!");
                counter++;
            }
            do
            {
                Console.WriteLine("Hallo, Welt!");

            } while (counter > 0);
        }
    }
}
