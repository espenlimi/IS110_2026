namespace Repetisjon1
{
    internal class Bil : Kjøretøy
    {
        public Bil(string merke, string modell, int årsmodell, string farge) : base(merke, modell, årsmodell, farge)
        {
        }

        public Bil(string merke, string modell, int årsmodell, string farge, int antallHjul) : base(merke, modell, årsmodell, farge, antallHjul)
        {
        }
        public override string ToString()
        {
            return $"Eg er ein bil! {Merke} {Modell} ({Årsmodell}), Farge: {Farge}";
        }
    }
}
