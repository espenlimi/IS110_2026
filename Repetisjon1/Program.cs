// See https://aka.ms/new-console-template for more information
using Repetisjon1;

Console.WriteLine("Hello, World!");
var bil1 = new Bil("Toyota", "Corolla", 2020, "Rød");
var bil2 = new Bil("Honda", "Civic", 2019, "Blå");
var bil3 = new Bil("Ford", "Focus", 2018, "Grønn");
var bil4 = new Bil("Tesla", "Model 3", 2021, "Sølv");


var parkeringsplass = new ParkeringsPlass();
parkeringsplass.VisParkeringsPlasser();

parkeringsplass.ParkerBil(bil1);
parkeringsplass.VisParkeringsPlasser();

parkeringsplass.ParkerBil(bil2);
parkeringsplass.VisParkeringsPlasser();

parkeringsplass.ParkerBil(bil3);
parkeringsplass.VisParkeringsPlasser();

parkeringsplass.ParkerBil(bil4);
parkeringsplass.VisParkeringsPlasser();

parkeringsplass.ForlatParkeringsPlass(bil2);
parkeringsplass.VisParkeringsPlasser();

parkeringsplass.ParkerBil(bil4);
parkeringsplass.VisParkeringsPlasser();
