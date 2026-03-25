using System;
using System.Collections.Generic;
using System.Text;

namespace Repetisjon2
{
    internal class SmsMeldingSender : AbstraktMeldingSender, IMeldingSender
    {
        public void SendMelding(Melding melding)
        {
            Console.WriteLine($"Sender SMS ");
            SkrivUtMelding(melding);
        }
    }
}
