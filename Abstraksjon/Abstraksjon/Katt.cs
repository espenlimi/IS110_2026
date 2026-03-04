using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraksjon
{
    internal class Katt : Dyr
    {
        public void Jakt() 
        {
            Console.WriteLine("Lusker rundt etter mat");
        }

        public override void LagLyd() 
        {
            Console.WriteLine("Mjau");
        
        }
    }
}
