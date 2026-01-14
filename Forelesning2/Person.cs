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
        private int id;
        private string navn;
        private DateOnly fødselsdato;
        private string adresse;

        // Konstruktøren
        public Person()
        {
            this.id = 0;
            this.navn = string.Empty;
        }

        // deklarer Set og Get metoder
        public void SetId(int personId)
        {
            id = personId;
        }

        public void SetNavn(string personNavn)
        {
            navn = personNavn;
        }

        public int GetId()
        {
            return id;
        }
        public string GetNavn()
        {
            return navn;
        }

        // metoden som skal skrive ut info om person
        public void VisInformasjon ()
        {
            Console.WriteLine("Person ID: " + id + " Person Name: " + navn);
            // string interpolation
            Console.WriteLine($"Person ID: {id} Person Name: {navn}");
        }
    }
}
