string? num1Line = Console.ReadLine();

if (num1Line != null)
{
    int num1 = int.Parse(num1Line);
    int check = num1 % 2;

    if (check == 0)
    {
        Console.WriteLine("Четное число");
    }
    else
    {
        Console.WriteLine("Нечетное число");
    }
}

