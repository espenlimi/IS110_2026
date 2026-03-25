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

        protected override void SkrivUtVerdi()
        {
            Console.WriteLine("Det tar en time å gå ned til Ørsta rådhus!");
        }
    }
}
