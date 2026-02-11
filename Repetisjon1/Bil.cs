using System;
using System.Collections.Generic;
using System.Text;

namespace Repetisjon1
{
    internal class Bil
    {
        public string Merke { get; set; }
        public string Modell { get; set; }
        public int Årsmodell { get; set; }
        public string Farge { get; set; }

        public int AntallHjul { get; set; } = 4;

        public Bil(string merke, string modell, int årsmodell, string farge)
        {
            Merke = merke;
            Modell = modell;
            Årsmodell = årsmodell;
            Farge = farge;
        }
        public Bil(string merke, string modell, int årsmodell, string farge, int antallHjul)
        {
            Merke = merke;
            Modell = modell;
            Årsmodell = årsmodell;
            Farge = farge;
            AntallHjul = antallHjul;
        }

        public override string ToString()
        {
            return $"{Merke} {Modell} ({Årsmodell}), Farge: {Farge}";
        }
       
    }
}
