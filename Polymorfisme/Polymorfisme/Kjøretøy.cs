using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    internal class Kjøretøy : IKjørbar, IServicebar
    {
        public int KiloMeterKjørtSidenSisteService {  get; set; }
        
        public void Kjør()
        {
            Console.WriteLine("Kjøretøyet kjører....");
        }

        public void StarteMotor()
        {
            Console.WriteLine("Kjøretøyet starter motoren....");
        }

        public void StoppeMotor()
        {
            Console.WriteLine("Kjøretøyet stopper motoren....");
        }

        public bool TrengerService()
        {
            return (KiloMeterKjørtSidenSisteService >= 15000);
            
        }

        public void UtførService()
        {
            Console.WriteLine("Kjøretøyet er under service....");
            KiloMeterKjørtSidenSisteService = 0;
        }
    }
}
