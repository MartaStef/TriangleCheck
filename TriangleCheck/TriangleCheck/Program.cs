using System.Drawing;

Console.WriteLine("Witaj w programie Triangle Check! Sprawdź czy podane kąty utworzą trójkąt");
Console.WriteLine();

List<string> angles = new List<string>()
{ "Alfa", "Beta", "Gamma" };
int sumAngle = 0;

List<int> intAngles = new List<int>();

while (true)
{
    intAngles.Clear();
    
    foreach (string angle in angles)
    {     
        bool invalidInput = true;
        while (invalidInput)  
        {
            Console.WriteLine($"Podaj wartość kąta {angle}:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int intAngle) && intAngle > 0 && intAngle < 180)
            {
                intAngles.Add(intAngle);
                invalidInput = false;
            }
            else if (intAngle <= 0 && intAngle >= 180)
            {
                Console.WriteLine("Nieprawidłowa wartość kąta. Spróbuj ponownie");
            }           
        }
    }

    var sum = intAngles.Sum();
    Console.WriteLine($"Suma Kątów wynosi: {sum}");

    if (sum == 180)
    {
        Console.WriteLine("Istnieje trójkąt dla podanych kątów. Spróbuj ponownie");
    }
    else if (sum != 180)
    {
        Console.WriteLine("Nie istnieje trójkąt dla podanych kątów. Spróbuj ponownie.");
    }

    Console.WriteLine("Czy chcesz sprawdzić kolejny trójkąt?");
    string nextTriangle = Console.ReadLine();
    if (nextTriangle == "Tak" || nextTriangle == "TAK" || nextTriangle == "tak")
    { continue; }
    else
    { break; }
}
    