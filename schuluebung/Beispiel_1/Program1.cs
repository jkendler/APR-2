using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = { "Max", "Daniela", "Sabine", "Johann" };

            Console.Write("Wieviele Schüler brauchen Sie: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            
            
            for (int i = 0; i < anzahl; i++)
            {
                int zahl = r.Next(0,anzahl);
                
                Console.WriteLine("{0}", students.GetValue(zahl));
            }

            Console.ReadLine();


        }
    }
}
