
Console.WriteLine("Sisesta sõna:");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); //userInput - argument

static void PrintAnyWord(string anyString) // anyString - Argument
{
    anyString = anyString.ToUpper(); 
    for (int i = 0; i <5; i++)
    {
        Console.WriteLine(anyString);
    }
}