using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueGetränke
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Flasche> schachtel = new List<Flasche>();
            schachtel.Add(new Flasche() { Durchmesser = 7, Hoehe = 25 });
            schachtel.Add(new Flasche() { Durchmesser = 7, Hoehe = 25 });

            schachtel.Add(new Flasche() { Durchmesser = 4, Hoehe = 20 });

            schachtel.Add(new Flasche() { Durchmesser = 8, Hoehe = 15 });
            schachtel.Add(new Flasche() { Durchmesser = 8, Hoehe = 15 });
            schachtel.Add(new Flasche() { Durchmesser = 8, Hoehe = 15 });
            schachtel.Add(new Flasche() { Durchmesser = 8, Hoehe = 15 });
            schachtel.Add(new Flasche() { Durchmesser = 8, Hoehe = 15 });

            double literGesamt = 0;
            foreach(Flasche f in schachtel)
            {
                literGesamt += f.Liter();
            }

            Console.WriteLine("Liter (gesamt): {0}",literGesamt);

            

        }
    }


    public class Flasche
    {
        public double Durchmesser { get; set; }

        public double Hoehe { get; set; }

        public double Liter()
        {
            //r2 * PI * h
            double r = Durchmesser / 2;
            return Math.Pow(r, 2) * Math.PI * Hoehe / 1000;
        }
    }

}
