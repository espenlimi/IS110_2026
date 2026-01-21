using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning2
{
    internal class TestInternal
    {
        public TestInternal() { }

        public void PrintMessage()
        {
            Console.WriteLine("Denne klassen er synlig kun for Forelesning2 prosjekt!");
        }
    }
}
