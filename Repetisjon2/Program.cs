using Repetisjon2;
using System.Threading.Tasks.Dataflow;
Console.WriteLine("Hello, repetisjonsforelesning 2");

//Snart påskefri :) 
//Avanserte emner 15 april
//Oppsummering og eksamensinfo 22 april
//Avlyst 29 april => Syntaks konf!

var melding = new Melding
{
    Avsender = "Espen",
    Mottaker = "Rania",
    Innhold = "Hei sveis!"
};


//FY! AbstraktMeldingSender meldingSender = new AbstraktMeldingSender();

var fabrikk = new MeldingSenderFabrikk();
IMeldingSender brevSender = fabrikk.LagMeldingSender("brev");
IMeldingSender smsSender = fabrikk.LagMeldingSender("sms");

brevSender.SendMelding(melding);
smsSender.SendMelding(melding);

/*
 Readme prompt:
Create a markdown file explaining behaviour and structure in project  
*/



//if kodeduplisering => vurder arv
//if Arv && ikke instans av superklasse =>vurder abstrakt
//if lik oppførsel && ulik implementasjon => vurder interface
//if superklasse trenger spesiell implementasjon i subklasser => vurder abstrakt
//else la være

var list = new Melding[1337];
var meldingerEspenHarSendt = from message in list
                             where message.Avsender == "Espen" && message.Mottaker == "Rania"
                             select message;

var innholdEspenHarSendt = list
    .Where(message => message.Avsender == "Espen")
    .Select(message => message.Innhold);
    








