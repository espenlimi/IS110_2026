// See https://aka.ms/new-console-template for more information
using Polymorfisme;

Console.WriteLine("Hello, World!");

Kjøretøy k = new PersonBil();
Kjøretøy t = new PersonBil();
Kjøretøy p = new PersonBil();
List<IServicebar> services = new List<IServicebar>();
services.Add(k);
services.Add(t);
services.Add(p);
services.Add(new PersonBil{KiloMeterKjørtSidenSisteService = 20000});

foreach(IServicebar service in services)
{
    if (service.TrengerService())
        service.UtførService();
}

// for å teste om det skal printe ut en gang til etter at antall kilometere igjen etter de ble satt til 0
foreach (IServicebar service in services)
{
    if (service.TrengerService())
        service.UtførService();
}

