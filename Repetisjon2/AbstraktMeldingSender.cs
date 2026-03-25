using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Repetisjon2
{
    internal abstract class AbstraktMeldingSender
    {
        protected void SkrivUtMelding(Melding melding)
        {
            Console.WriteLine($"Avsender: {melding.Avsender} ");
            Console.WriteLine($"Mottaker: {melding.Mottaker}");
            Console.WriteLine($"Innhold: {melding.Innhold}");
        }
    }
}
