Console.WriteLine("Witaj w programie Triangle Check! Sprawdź czy podane kąty utworzą trójkąt");
Console.WriteLine("Wpisz 0 jesli chcesz zakonczyć program");
Console.WriteLine();

while (true)
{
    Console.WriteLine("Podaj wartość kąta Alfa:");
    var inputAlfa = int.Parse(Console.ReadLine());
    if(inputAlfa == 0)
    { break; }

    Console.WriteLine("Podaj wartość kąta Beta:");
    var inputBeta = int.Parse(Console.ReadLine());

    Console.WriteLine("Podaj wartość kąta Gamma:");
    var inputGamma = int.Parse(Console.ReadLine());

    var sum = inputAlfa + inputBeta + inputGamma;
    Console.WriteLine($"Suma Kątów wynosi: {sum}");

    if (sum == 180)
    {
        Console.WriteLine("Istnieje trójkąt dla podanych kątów. Spróbuj ponownie");
    }
    else if (sum != 180)
    {
        Console.WriteLine("Nie istnieje trójkąt dla podanych kątów. Spróbuj ponownie.");
    }
}
    