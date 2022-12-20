// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int numB1 = ReadData("Введите b1");
int numK1 = ReadData("Введите k1");
int numB2 = ReadData("Введите b2");
int numK2 = ReadData("Введите k2");

PrintData("Координаты точки пересечения: x (" + ((numB2 - numB1) / (numK1 - numK2)) + ");" + " y (" + ((numK1 * ((numB2 - numB1) / (numK1 - numK2)) + numB1)) + ")");

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}
