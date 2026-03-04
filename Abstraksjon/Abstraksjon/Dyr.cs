using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraksjon
{
    internal abstract class Dyr
    {

        public void GjørTing()
        {
            LagLyd();
            Sove();
            LagLyd();

        }

        public void Sove()
        {
            Console.WriteLine("zzzzzzzz");
        }

        public abstract void LagLyd();

    }
}
