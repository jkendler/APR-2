using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schuluebung_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Max", "Daniela", "Sabine", "Johann" };

            Console.Write("Anzahl der Schüler: ");
            double anzahl = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            for (int i = 0; i < anzahl; i++)
            {
                int zahl = r.Next(0,students.Length);

                Console.WriteLine("{0}", students.GetValue(zahl));


            }
        }
    }
}
