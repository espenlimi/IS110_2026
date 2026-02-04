sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    public class TestTilgangKlasse
    {
        private string privatFelt = "Dette er et privat felt"; // tilgjengelig kun i denne klassen (kan bruke set og get metoder her)
        protected string protctedFelt = "Dette er et protected felt";
        private protected string privatProtectedFelt = "Dette er et privat protected felt";
        protected internal string protectedInternalFelt = "Dette er et protected internal felt";
    }
}
