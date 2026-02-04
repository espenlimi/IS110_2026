namespace ConsoleApp1
{
    public class EksternKlasse : TestTilgangKlasse
    {
        public void TestTilgangEkstern()
        {
            Console.WriteLine($"klassen kan få tilgang til {protectedInternalFelt} og {protctedFelt}");
        }
    }
}
