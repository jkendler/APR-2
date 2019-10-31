using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhdimArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] kosten =
            {

                {1, 2, 3, 4, 2 },
                {2, 5, 7, 10, 3 },
                {5, 10, 15, 20, 4},
                {25, 44, 23, 11, 6}

            };

            for (int i = 0; i < kosten.GetLength(1); i++)
            {
                Console.WriteLine(kosten[0,i]);
            }


            string[,] ziehungen =
            {
                {"Hansi", "Maxi" },
                {"Josef", "Mohamed" },
                {"Daniela","Murat" },
                {"Julia","David"},
                {"Frieda","Adam" },
                {"Josefine","Eva" },
                {"Marie","Bernhard" }


            };

            Console.WriteLine("Anzahl der Ziehungen {0}",ziehungen.GetLength(0));
            Console.WriteLine("Anzahl der Gewinner {0}", ziehungen.Length);
            Console.WriteLine("Gewinner pro Ziehung {0}", ziehungen.GetLength(1));

            for (int i = 0; i < ziehungen.GetLength(0); i++)
            {
                Console.WriteLine("Gewinner: {0}",ziehungen[i,1]);
            }

        }
    }
}
