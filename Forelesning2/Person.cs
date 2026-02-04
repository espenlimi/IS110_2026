using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    public class Person
    {
        // Deklarer instansvariabler
        //private int id;
        private protected string navn;
        private protected int alder;
        //private DateOnly fødselsdato;
        //private string adresse;

        public int Id { get; set; }
        public string Navn { get; set; } = string.Empty;
         public int Alder { get; set; }

        // Konstruktøren
        public Person()
        {
            //this.id = 0;
            //this.navn = string.Empty;
            Navn = string.Empty;

        }

        // Konstruktør med parametere
        public Person(string n, int a)
        {
            navn = n;
            alder = a;
        }

         // virtual muliggjør at vi kan endre logikken i Student klassen
         public virtual void Introduce()
         {
             Console.WriteLine($"Navnet til personen er: {navn}, og alderen er: {alder}");
         }

         // en metode som vi skal kalle fra student
         protected void SkrivUtTekst() {
             Console.WriteLine("direkte metodekall!");
         }

        // deklarer Set og Get metoder
        //public void SetId(int personId)
        //{
        //    id = personId;
        //}

        //public void SetNavn(string personNavn)
        //{
        //    navn = personNavn;
        //}

        //public int GetId()
        //{
        //    return id;
        //}
        //public string GetNavn()
        //{
        //    return navn;
        //}

        // metoden som skal skrive ut info om person
        public void VisInformasjon ()
        {
            Console.WriteLine("Person ID: " + Id + " Person Name: " + Navn);
            // string interpolation
            Console.WriteLine($"Person ID: {Id} Person Name: {Navn}");
        }
    }
}
