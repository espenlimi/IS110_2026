// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Forelesning2;
using System;


// få verdier fra brukeren i terminalen
//int idVerdi = int.Parse(Console.ReadLine());
//string navnVerdi = Console.ReadLine();

// datatype (Person) variabel navn (p) = nytt objekt (new) konstruktøren Person()
//Person p = new Person();

// Set metoder
//p.SetId(123);
//p.SetNavn("Espen");

// Vanlig metode kall
//p.VisInformasjon();

// Skriv ut verdier som vi fikk fra brukeren
//p.SetId(idVerdi); 
//p.SetNavn(navnVerdi);

// Bruk av Get metoden for spesifikke felt
//string pNavn = p.GetNavn();
//Console.WriteLine(pNavn);
//Console.WriteLine(p.GetNavn());

////////////////// Bruk av auto-implementerte egenskaper ////////////////////////////////////////
//p.Id = idVerdi;
//p.Navn = navnVerdi;
//p.VisInformasjon();

////////////// Test av tilgangsmodifikatorer /////////////////////////////////////// 
//Bruker nyBruker = new Bruker("espenlimi");
//nyBruker.Passord = "123abc";
//Console.WriteLine(nyBruker.BrukerNavn);
//Får feil fordi passordet er beskyttet med privat get
// Console.WriteLine(nyBruker.Passord);


///////////////////// List /////////////////////////////////////////////
/* List<Person> persons = new List<Person>();

var espen = new Person();
espen.Id = 1;
espen.Navn = "Esp1m";
espen.Alder = 43;

persons.Add(espen);

persons.Add(new Person
{
    Alder = 29,
    Navn = "Rania",
    Id = 2
});

persons.Add(new Person
{
    Alder = 28,
    Navn = "Kjetil",
    Id = 3
});

persons.Add(new Person
{
    Alder = 100,
    Navn = "Magne",
    Id = 4
}); 
*/

///////////////// Løkke for å gå gjennom listen /////////////////////////////////
/* foreach (Person person in persons)
{
    Console.WriteLine($"Navn: {person.Navn}, Alder: {person.Alder}");
}


///////////////////// Legge til et element i listen i en bestemt posisjon ///////////////////////////
persons.Insert(1, new Person
{
    Alder = 25,
    Navn = "Mikael",
    Id = 5
});

Console.WriteLine();

foreach (Person person in persons)
{
    Console.WriteLine($"Navn: {person.Navn}, Alder: {person.Alder}");
}
*/

/////////////////// LINQ + List ////////////////////////////////////////////////////
/* var personQuery = from person in persons
                  where person.Alder > 30 && person.Navn.ToUpper().Contains('M')
                  orderby person.Alder descending
                  select person;

Console.WriteLine("Person query 1");
foreach (Person person in personQuery)
{
    Console.WriteLine($"Navn: {person.Navn}, Alder: {person.Alder}");
}

//////////////////// Lambda uttrykk + LINQ //////////////////////////////////////////
var personQuery2 = persons.Where(person => person.Alder > 30)
                          .OrderByDescending(person => person.Alder);

// skrive ut etter bruk av lambda uttrykk
Console.WriteLine("Person query 2");
foreach (Person person in personQuery2)
{
    Console.WriteLine($"Navn: {person.Navn}, Alder: {person.Alder}");
}
*/

///////////////////////////// Eksempel på LINQ + Array ////////////////////////////////////////
// Eksempel 1:
// Datakilde
/* int[] scores = { 97, 92, 81, 60 };

// LINQ spørring 
var scoreQuery =
    from score in scores
    where score > 80
    select score;

Console.WriteLine("Higher scores: ");

// Utfør LINQ spørringen
foreach (var i in scoreQuery)
{
    Console.WriteLine(i + " ");
}

// Eksempel 2:
// Datakilde
int[] numbers = { 1, 2, 3, 4, 5, 6 };

// LINQ spørring
var numQuery = from num in numbers
               where (num % 2) == 0
               select num;

Console.WriteLine("Even number: ");

// Utfør LINQ spørringen
foreach (int num in numQuery)
{
    Console.WriteLine(num);
}
*/
///////////////////////////// LINQ + List ////////////////////////////////////////

// Eksempel 3:

// Datakilde
/* List<string> fruits = new List<string> { "apple", "banana", "cherry" };

// LINQ spørringen
var wordLengths = from w in fruits
                  select w.Length;

Console.WriteLine("word length: ");

// Utfør LINQ spørringen
foreach (int l in wordLengths)
{
    Console.WriteLine(l);
}

// Eksempel 4:
// LINQ spørringen
var fruitContains = from f in fruits
                    where f.Contains('n')
                    select f;

Console.WriteLine("fruit's name contains n: ");

// Utfør LINQ spørringen
foreach (string f in fruitContains)
{
    Console.WriteLine(f);
}
*/

//////////////////Arv og tilgang/////////////////////////////////////
Student s = new Student("Ole", 20, "A", "IS-110");
Person p = new Student("Ida", 19, "A", "IS-110");
Person p2 = new Person("Fredrik", 20);
p.Introduce();
Console.WriteLine();
s.Introduce();
Console.WriteLine();
p2.Introduce();

ChildTestTilgangKlasse t = new ChildTestTilgangKlasse();
t.TestTilgang();
VanligKlasse v = new VanligKlasse();
TestTilgangKlasse k = new TestTilgangKlasse();
v.TestTilgangVanlig(k);
