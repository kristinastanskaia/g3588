﻿string? num1Line = Console.ReadLine();       // Считываем данные с консоли

if (num1Line != null)     // Проверяем, чтобы данные были не пустыми
{
    int num1 = int.Parse(num1Line);     // Парсим введеное число
    int check = num1 % 2;       // Находим остаток от деления на 2

    if (check == 0)      // Проверям, равен ли остаток от делению нулю
    {
        Console.WriteLine("Четное число");
    }
    else
    {
        Console.WriteLine("Нечетное число");
    }
}

