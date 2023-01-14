// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод выводит результат
void PrintResult(string prefix, int a)
{
    Console.WriteLine(prefix + a);
}

// Метод вычисляет функцию Аккермана
int AkkerFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return AkkerFunc(m - 1, 1);
    else
        return AkkerFunc(m - 1, AkkerFunc(m, n - 1));
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int result = AkkerFunc(number1, number2);
PrintResult("Результат функции: ", result);
