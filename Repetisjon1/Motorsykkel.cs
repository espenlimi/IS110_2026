namespace Repetisjon1
{
    internal class Motorsykkel : Kjøretøy
    {
        public Motorsykkel(string merke, string modell, int årsmodell, string farge) : base(merke, modell, årsmodell, farge, 2)
        {
        }
        public override string ToString()
        {
            return $"Jeg er en Motorsykkel! {Merke} {Modell} ({Årsmodell}), Farge: {Farge}";
        }

        public override string LydSignal()
        {
            return "PIP PIP!";
        }
    }
}
