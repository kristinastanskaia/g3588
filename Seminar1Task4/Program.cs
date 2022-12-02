string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

if (num1Line != null && num2Line != null && num3Line != null)
{
    int num1 = int.Parse(num1Line);
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

    if (num1 > num2)
    {
        if (num1 > num3)
        {
            Console.WriteLine("max " + num1);
        }
        else
        {
            Console.WriteLine("max " + num3);
        }
    }
    else
    {
        if (num2 < num3)
        {
            Console.WriteLine("max " + num3);
        }
        else
        {
            Console.WriteLine("max " + num2);
        }
    }
}
