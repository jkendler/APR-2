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
