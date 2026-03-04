using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraksjon
{
    internal abstract class AbstractA
    {
        public abstract string GetName();
    }
    internal abstract class AbstractB : AbstractA 
    {
    }
    internal class ConcreteC : AbstractB
    {
        public override string GetName() 
        {
            return "Esp1";
        }
    }

}
