using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Daniela","Muster");
           // p.Firstname = "Daniela";
            //p.Surname = "Muster";
            Console.WriteLine("Vorname: {0}",p.Firstname);
            Console.WriteLine("Nachname: {0}",p.Surname);

            //Eigenschaft DisplayName
            Console.WriteLine("Anzeigename: {0}",p.DisplayName);

            //Methode holeAnzeigename()
            Console.WriteLine("Anzeigename: {0}",p.holeAnzeigename());

            //Eigenschaft DisplayName2
            Console.WriteLine("Anzeigename: {0}", p.DisplayName2);

            Person p2 = new Person() { Firstname = "Julia", Surname = "Huber" };
            Console.WriteLine("Vorname: {0}, Nachname: {1}", p2.Firstname,p2.Surname);

            string[] zeichenkette = new string[3];
            zeichenkette[0] = "Sonne";
            zeichenkette[1] = "Mond";
            zeichenkette[2] = "Sterne";

            Console.WriteLine(p.sayHello());
            Console.WriteLine(p2.sayHello());


            Person[] personen = new Person[2];
            personen[0] = p;
            personen[1] = p2;

            Console.WriteLine(personen[0].sayHello());

            for (int i = 0; i < personen.Length; i++)
            {
                Console.WriteLine(personen[i].sayHello());
            }
            //mit foreach alle begrüßen
            foreach (var per in personen)
            {
                Console.WriteLine(per.sayHello());
            }


            List<Person> people = new List<Person>();
            people.Add(p);
            people.Add(p2);

            foreach (var per in personen)
            {
                Console.WriteLine(per.sayHello());
            }

        }
    }

    class Person
    {
        //Standartkonstruktor

        public Person() { }
        public Person(string firstname, string surname)
        {
            Firstname = firstname;
            Surname = surname;
        }

      

        public string Firstname{ get; set; }

        public string Surname { get; set; }

        public string DisplayName //Eigenschaft
        {
            get
            {
                var display = $"{Firstname} {Surname}";
                return display;
            }
        }
        public string holeAnzeigename() //Methode
        {
            var display = $"{Firstname} {Surname}";
            return display;
        }

        public string DisplayName2 => $"{Firstname} {Surname}";


        public string sayHello()
        {
            return String.Format("Hallo ich bin {0} {1}",Firstname,Surname);
        }

    }
}
