using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zug
{
    class Program
    {
        static void Main(string[] args)
        {
            Train t = new Train(10000);

            t.Add(new Waggon("Holz", 20000));
            t.Add(new Waggon("Kohle", 40000));
            t.Add(new Waggon("Holz", 20000));

            string inhalt = t.Ware();
            Console.WriteLine(inhalt);

            Console.WriteLine(t.fahre());
        }
    }

    class Train
    {
        List<Waggon> waggons = new List<Waggon>();

        double Staerke { get; set; }

        public Train(double staerke)
        {
            Staerke = staerke;
        }

        public void Add(Waggon w)
        {
            waggons.Add(w);
        }

        double gewicht()
        {
            double summe = 0;
            foreach (var w in waggons)
            {
                summe += w.Gewicht;
            }
            return summe;
        }
        public string fahre()
        {
            double transportgewicht = gewicht();

            if(transportgewicht > Staerke)
            {
                return "grrr geht nicht";
            }
            else
            {
                return "tr tr tr tr";
            }
            
        }
        public string Ware()
        {
            string inhalt = "";

            foreach(Waggon w in waggons)
            {
                inhalt += " " + w.Ware;
            }

            return inhalt;

        

        }
      
    }
    class Waggon
    {
        public string Ware { get; set; }

        public double Gewicht { get; set; }

        public Waggon(string ware, double gewicht)
        {
            Ware = ware;
            Gewicht = gewicht;
        }

    }


}
