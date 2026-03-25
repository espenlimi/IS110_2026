using System;
using System.Collections.Generic;
using System.Text;

namespace Repetisjon2
{
    internal class BrevMeldingSender : AbstraktMeldingSender, IMeldingSender
    {
        public void SendMelding(Melding melding)
        {
            Console.WriteLine($"Sender Brev ");
            SkrivUtMelding(melding);
        }

        protected override void SkrivUtVerdi()
        {
            Console.WriteLine(42);
        }
    }
}
 