using Repetisjon2;

Console.WriteLine("Hello, repetisjonsforelesning 2");

//Avanserte emner 15 april
//Oppsummering og eksamensinfo 22 april
//Avlyst 29 april => Syntaks konf!

var melding = new Melding
{
    Avsender = "Espen",
    Mottaker = "Rania",
    Innhold = "Hei sveis!"
};

var fabrikk = new MeldingSenderFabrikk();
IMeldingSender brevSender = fabrikk.LagMeldingSender("brev");
IMeldingSender smsSender = fabrikk.LagMeldingSender("sms");


brevSender.SendMelding(melding);
smsSender.SendMelding(melding);