string? num1Line = Console.ReadLine();  // Считываем данные с консоли
string? num2Line = Console.ReadLine();

if (num1Line != null && num2Line != null)   // Проверяем, чтобы данные были не пустыми
{
    int num1 = int.Parse(num1Line); // Парсим введеное число
    int num2 = int.Parse(num2Line);

    if (num1 == num2)   // Проверяем, равны ли числа?
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        if (num1 > num2)    // Проверяем, первое число больше второго?
        {
            Console.WriteLine("Первое число больше второго");
        }
        else
        {
            Console.WriteLine("Второе число больше первого");
        }
    }
}
