using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraksjon
{
    internal class Dyrehage
    {
        public static List<Dyr> AlleDyr = new List<Dyr>
        {
            new Katt(),
            new Papegøye()
        };
    }
}
