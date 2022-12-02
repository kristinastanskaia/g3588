string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

if (num1Line != null && num2Line != null)
{
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);

    if (num1 > num2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else
    {
        Console.WriteLine("Второе число больше первого");
    }
}