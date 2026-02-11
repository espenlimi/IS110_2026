using System;
using System.Collections.Generic;
using System.Text;

namespace Repetisjon1
{
    internal class ParkeringsPlass
    {
        private Bil[] plasser = new Bil[3];

        public bool ParkerBil(Bil bil)
        { 
            var index = 0;
            while (index < plasser.Length)
            { 
                if(plasser[index] == null)
                {
                    plasser[index] = bil;
                    return true;
                }
                index++;
            }
            return false;
        }

        public bool ForlatParkeringsPlass(Bil bil)
        {
            var query = from parkertBil in plasser
                        where parkertBil == bil
                        select parkertBil;

            if(query.Any())
            {
                var index = Array.IndexOf(plasser, bil);
                plasser[index] = null;
                return true;
            }
            return false;
        }

        public void VisParkeringsPlasser()
        {
            for (int i = 0; i < plasser.Length; i++)
            {
                if (plasser[i] != null)
                {
                    Console.WriteLine($"Plass {i + 1}: {plasser[i]}");
                }
                else
                {
                    Console.WriteLine($"Plass {i + 1}: Tom");
                }
            }
        }
    }
}
