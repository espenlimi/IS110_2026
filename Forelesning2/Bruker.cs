using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    internal class Bruker
    {
        public string BrukerNavn { get; private set; }
        public string Passord { private get; set; }
        
        public Bruker(string brukerNavn)
        {
            BrukerNavn = brukerNavn;
        }
    }
}
