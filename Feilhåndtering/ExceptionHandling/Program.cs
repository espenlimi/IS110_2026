// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

string[] navn = new string[3];
navn[0] = "Anna";
navn[1] = null;
navn[2] = "Ola";

for (int i = 0; i <= navn.Length; i++)
{
    try
    {
        Console.WriteLine(navn[i].ToUpper());
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine($"Verdien for index {i} var null");
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine($"Index {i} er utenfor rekkevidde");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"En feil oppsto: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Dette kjøres uansett om det oppsto en feil eller ikke.");
    }
}

var input = int.Parse(Console.ReadLine());

var examples = new Examples();
var result = examples.Run(input);
Console.WriteLine(result.Name + " " + result.HadError);