using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Vorname = "Max";
            p.Vorname = "";
            p.Nachname = "Huber";
            p.Nachname = "";
            Console.WriteLine(p.Vorname);
            Console.WriteLine(p.Nachname);

            Auto a = new Auto();
            a.AnzahlReader = 8;
        }
    }
    class Person
    {

        private string vorname;
        private string nachname;
        public string Vorname
        {
            get { return vorname; }
            set
            {
                if (value != "")
                { 
                    vorname = value; 
                }
                
            }
        }

        public string Nachname
        {
            get { return nachname; }
            set
            {
                if (value != "")
                {
                    nachname = value;
                }

            }
        }

    }

    class Auto
    {
        public int AnzahlReader { get; set; } = 4;

    }
}
