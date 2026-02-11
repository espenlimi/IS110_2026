namespace Repetisjon1
{
    internal class Traktor : Kjøretøy
    {
        public Traktor(string merke, string modell, int årsmodell, string farge) : base(merke, modell, årsmodell, farge)
        {
        }

        public Traktor(string merke, string modell, int årsmodell, string farge, int antallHjul) : base(merke, modell, årsmodell, farge, antallHjul)
        {
        }

    }
}
