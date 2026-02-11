using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    // ar er implementert ved bruk av (:)
    public class Student : Person
    {
        public string Karakter { set; get; }
        public string Kurs { set; get; }

        // her refererer vi til Person sin konstruktør ved bruk av base(a, b)
        public Student(string n, int a, string karakter, string kurs) : base(n, a)
        {
            Karakter = karakter;
            Kurs = kurs;
        }

        public override void Introduce()
        {
            // direkte kall til SkrivUtTekst() metoden (her bruker vi metoden uten å endre logikken
            base.SkrivUtTekst();

            // her endrer vi logikken til Introduce() metoden enn den versjonn som ligger i Person
            Console.WriteLine($"Studentens navn er {navn}, alder er {alder}, har karakter {Karakter} i kurs {Kurs}");
        }
    }
}
