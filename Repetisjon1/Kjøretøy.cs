using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repetisjon1
{
    internal class Kjøretøy
    {
        public string KjenneMerke { get { return KjenneMerke; }
                                    set { if (KjenneMerke == null)
                                            { KjenneMerke = value; } 
                                        }
                                  }
        public string Merke { get; set; }
        public string Modell { get; set; }
        public int Årsmodell { get; set; }
        public string Farge { get; set; }

        public int AntallHjul { get; set; } = 4;

        
        public Kjøretøy(string merke, string modell, int årsmodell, string farge)
        {
            Merke = merke;
            Modell = modell;
            Årsmodell = årsmodell;
            Farge = farge;
        }
        public Kjøretøy(string merke, string modell, int årsmodell, string farge, int antallHjul)
        {
            Merke = merke;
            Modell = modell;
            Årsmodell = årsmodell;
            Farge = farge;
            AntallHjul = antallHjul;
        }
     
        public override string ToString()
        {
            return $"Kjøretøy?? {Merke} {Modell} ({Årsmodell}), Farge: {Farge}";
        }

        public virtual string LydSignal()
        { 
            return "TUT TUT!";
        }
    }
}
