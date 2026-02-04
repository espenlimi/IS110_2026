using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    public class ChildTestTilgangKlasse : TestTilgangKlasse
    {
        public void TestTilgang() { 
            Console.WriteLine($"subklassen kan få tilgang til: {protctedFelt}, {privatProtectedFelt} og {protectedInternalFelt}");
        }
    }
}
