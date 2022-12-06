int firstNumber = int.Parse(Console.ReadLine() ?? "0");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

int result1 = firstNumber * firstNumber;
int result2 = secondNumber * secondNumber;

if (result1 == secondNumber)
{
    Console.WriteLine("да");
}
else
{
    if (result2 == firstNumber)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

