using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Tafel tafel2b = new Tafel(); //Objekt
            Console.WriteLine(tafel2b.farbe);

            tafel2b.schreibeText("Das ist ein Test! ");
            tafel2b.schreibeText("Pass auf");
            string ausgabe = tafel2b.zeigeInhalt();
            Console.WriteLine("Tafel der 2b: {0}",ausgabe);

            Console.Clear();
            tafel2b.loescheTafel();
            tafel2b.schreibeText("Hallo, Welt");
            ausgabe = tafel2b.zeigeInhalt();
            Console.WriteLine(ausgabe);



            Tafel tafel1a = new Tafel(); //Objekt
            tafel1a.farbe = "weiß";
            Console.WriteLine(tafel1a.farbe);




            /*
            Konto max = new Konto();
            max.kontostand = 123.45;
            Console.WriteLine("Kontostand {0}",max.kontostand);
            */
        }
    }


    class Tafel
    {
        //Die Standart-Farbe der Tafel
        public string farbe = "grün";

        //der Inhalt der Tafel
        //string text = "";
        List<string> text = new List<string>();



        /// <summary>
        /// Schreibt einen Text auf die Tafel
        /// </summary>
        /// <param name="inhalt">Der Text, der der Tafel hinzugefügt wird.</param>
        public void schreibeText(string inhalt)
        {
            // text = text + inhalt;
            text.Add(inhalt);
        }

        /// <summary>
        /// Löscht den Inhalt der Tafel
        /// </summary>
        public void loescheTafel()
        {
            text.Clear();
        }

        /// <summary>
        /// Zeigt den Inhalt der Tafel an.
        /// </summary>
        /// <returns>Liefert den Inhalt zurück.</returns>
        public string zeigeInhalt()
        {
            var inhaltListe = "";
            foreach (var item in text)
            {
                inhaltListe = inhaltListe + item;
            }

            return inhaltListe;
        }
      
    }
    

    class Konto
    {
       private double kontostand = 0.0;
    }
    
    
}
