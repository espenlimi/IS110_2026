using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraksjon
{
    internal class Papegøye : Dyr
    {

        public void FinnerMat()
        {
            Console.WriteLine("Flyr rundt og myser etter bær og snacks");
        }
        public override void LagLyd()
        {
            Console.WriteLine("Squæææk!");
        }

        public void Fly()
        {
            Console.WriteLine("Flakse!");
        }
    }
}
