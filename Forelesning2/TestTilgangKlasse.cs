using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    /////// Vi skal teste tilgangen til de feltene i denne klassen fra subklasse (ChildTestTilgangKlasse.cs) inn i Forelesning2 prosjekt, vanlig kasse uten arv (VanligKlasse.cs) inn i Forelesning2 prosjekt og en subklasse (EksternKlasse.cs) inn i ConsoleApp1 prosjekt (annet prosjekt)
    public class TestTilgangKlasse
    {
        private string privatFelt = "Dette er et privat felt"; // tilgjengelig kun for denne klassen (kan bruke set og get metoder her)
        protected string protctedFelt = "Dette er et protected felt";  // tilgjengelig kun for denne klassen, subklassen (ChildTestTilgangKlasse.cs) og subklassen (EksternKlasse.cs)
        private protected string privatProtectedFelt = "Dette er et privat protected felt"; // tilgjengelig kun for denne klassen og subklassen (ChildTestTilgangKlasse.cs)
        protected internal string protectedInternalFelt = "Dette er et protected internal felt"; // tilgjengelig for denne klassen, subklassen (ChildTestTilgangKlasse.cs) i samme prosjekt, vanlig klasse uten arv (VanligKlasse.cs) i samme prosjekt og subklassen (EksternKlasse.cs) i annet prosjekt
    }
}
