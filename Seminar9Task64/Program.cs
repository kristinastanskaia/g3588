// Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод выводит результат
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Метод генерит числовой ряд (рекурсия)
string LineGenRec(int num)
{
    if (num <= 0) return string.Empty;
    string outLine = num + " " + LineGenRec(num - 1);
    return outLine;
}

int number = ReadData("Введите число N: ");
string resultLine = LineGenRec(number);
PrintResult(resultLine);