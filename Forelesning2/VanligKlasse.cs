using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    public class VanligKlasse
    {
        public void TestTilgangVanlig(TestTilgangKlasse t)
        {
            Console.WriteLine($"klassen kan få tilgang til: {t.protectedInternalFelt}");
        }
    }
}
