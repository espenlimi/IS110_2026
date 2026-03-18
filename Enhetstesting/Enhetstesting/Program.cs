using Enhetstesting;

var calc = new Calculator();
double result = 0;

// Valg #1
//calc.AddNumbers(1, 3);
//calc.SubtractNumbers(4, 2);
//calc.MultiplyNumbers(5, 3);
//calc.DivideNumbers(6, 4);

// Valg #2
Console.WriteLine("Vennligst gi verdi til tall 1");
int verdi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Vennligst gi verdi til tall 2");
int verdi2 = int.Parse(Console.ReadLine());

Console.WriteLine("Vennligst velg en operasjon");
string op = Console.ReadLine();

if (op == "+")
{
    result = calc.AddNumbers(verdi1, verdi2);
}
else if (op == "-")
{
    result = calc.SubtractNumbers(verdi1, verdi2);
}
else if (op == "*")
{
    result = calc.MultiplyNumbers(verdi1, verdi2);
}
else if (op == "/")
{
    result = calc.DivideNumbers(verdi1, verdi2);
}

Console.WriteLine($"Resultatet er: {result}");

