using System;
using System.Collections.Generic;
using System.Text;

namespace Repetisjon1
{
    internal class ParkeringsPlass
    {
        private Kjøretøy[] plasser = new Kjøretøy[8];

        public bool ParkerKjøretøy(Kjøretøy kjøretøy)
        {
            if (ErKjøretøyParkert(kjøretøy))
                return true;

            var index = 0;
            while (index < plasser.Length)
            { 
                if(plasser[index] == null)
                {
                    plasser[index] = kjøretøy;
                    return true;
                }
                index++;
            }
            return false;
        }

        public bool ForlatParkeringsPlass(Kjøretøy kjøretøy)
        {
            if(ErKjøretøyParkert(kjøretøy))
            {
                var index = Array.IndexOf(plasser, kjøretøy);
                plasser[index] = null;
                return true;
            }
            return false;
        }

        private bool ErKjøretøyParkert(Kjøretøy kjøretøy)
        {
            return plasser.Contains(kjøretøy);
        }

        public void VisParkeringsPlasser()
        {
            for (int i = 0; i < plasser.Length; i++)
            {
                if (plasser[i] != null)
                {
                    Console.WriteLine($"Plass {i + 1}: {plasser[i]} - {plasser[i].LydSignal()}");
                    
                }
                else
                {
                    Console.WriteLine($"Plass {i + 1}: Tom");
                }
            }
        }
    }
}
