string? num1Line = Console.ReadLine();  // Считываем данные с консоли
string? num2Line = Console.ReadLine();
string? num3Line = Console.ReadLine();

if (num1Line != null && num2Line != null && num3Line != null)   // Проверяем, чтобы данные были не пустыми
{
    int num1 = int.Parse(num1Line); // Парсим введеное число
    int num2 = int.Parse(num2Line);
    int num3 = int.Parse(num3Line);

    if (num1 > num2)    // Проверяем, первое число больше второго?
    {
        if (num1 > num3) // Проверяем, первое число больше третьего?
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
        if (num2 < num3)    // Проверяем, второе число меньше третьего?
        {
            Console.WriteLine("max " + num3);
        }
        else
        {
            Console.WriteLine("max " + num2);
        }
    }
}
