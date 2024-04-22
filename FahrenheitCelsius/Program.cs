Console.WriteLine("Kas soovite temperatuuri teisendada Celsiusse [C] või Fahrenheiti [F]?");
char userOperator = Char.Parse(Console.ReadLine());
char suurTäht = char.ToUpper(userOperator);

Console.WriteLine("Sisestage temperatuur:");
int temperatuur = Int32.Parse(Console.ReadLine());


switch (suurTäht)
{
    case 'C':
        ConverToCelsius (temperatuur);
        break;
    case 'F':
        ConverToFahrenheit(temperatuur);
        break;
    default:
        Console.WriteLine("Vale sisend");
        break;
}

static void ConverToCelsius(int fahrenheit)
{
    Console.WriteLine($"Temperatuur Celsiuses on {((fahrenheit - 32 ) * 5)/9}");
}

static void ConverToFahrenheit(int celsius)
{
    Console.WriteLine($"Temperatuur Fahrenheitides on {(celsius * 9) / 5 + 32}");
}