using Repetisjon1;

var bil1 = new Bil("Toyota", "Corolla", 2020, "Rød");
var bil2 = new Bil("Honda", "Civic", 2019, "Blå");
var bil3 = new Kjøretøy("Ford", "Focus", 2018, "Grønn");
var bil4 = new Bil("Tesla", "Model 3", 2021, "Sølv");
var motorSykkel1 = new Motorsykkel("Yamaha", "MT-07", 2020, "Svart");
var motorSykkel2 = new Motorsykkel("Kawasaki", "Ninja 400", 2019, "Grønn");
var traktor = new Traktor("John Deere", "X350", 2017, "Grønn");

var parkeringsplass = new ParkeringsPlass();
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(bil1);
parkeringsplass.ParkerKjøretøy(bil1);
parkeringsplass.ParkerKjøretøy(bil1);
parkeringsplass.ParkerKjøretøy(bil1);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(bil2);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(bil3);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(bil4);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ForlatParkeringsPlass(bil2);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(bil4);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(motorSykkel1);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(motorSykkel2);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();

parkeringsplass.ParkerKjøretøy(traktor);
parkeringsplass.VisParkeringsPlasser();
Console.WriteLine();