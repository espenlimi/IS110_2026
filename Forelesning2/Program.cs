// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Forelesning2;


// få verdier fra brukeren i terminalen
int idVerdi = int.Parse(Console.ReadLine());
string navnVerdi = Console.ReadLine();

// datatype (Person) variabel navn (p) = nytt objekt (new) konstruktøren Person()
Person p = new Person();
//p.SetId(123);
//p.SetNavn("Espen");
//p.VisInformasjon();

// Skriv ut verdier som vi fikk fra brukeren
//p.SetId(idVerdi); 
//p.SetNavn(navnVerdi);

p.Id = idVerdi;
p.Navn = navnVerdi;
p.VisInformasjon();

// Bruk av Get metoden for spesifikke felt
//string pNavn = p.GetNavn();
//Console.WriteLine(pNavn);
//Console.WriteLine(p.GetNavn());

Bruker nyBruker = new Bruker("espenlimi");
nyBruker.Passord = "123abc";
Console.WriteLine(nyBruker.BrukerNavn);
//Får feil fordi passordet er beskyttet med privat get
// Console.WriteLine(nyBruker.Passord);