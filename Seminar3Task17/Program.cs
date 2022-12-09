//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//в которой находится эта точка.

// //Вводим данные
// Console.WriteLine("Введите координату X");
// int numX = int.Parse(Console.ReadLine() ?? "0");

// Console.WriteLine("Введите координату Y");
// int numY = int.Parse(Console.ReadLine() ?? "0");

// //Выводим решение
// if (numX > 0 && numY > 0) Console.WriteLine("Точка в четверти 1");
// if (numX > 0 && numY < 0) Console.WriteLine("Точка в четверти 2");
// if (numX < 0 && numY < 0) Console.WriteLine("Точка в четверти 3");
// if (numX < 0 && numY > 0) Console.WriteLine("Точка в четверти 4");

//Вариант 2 (метод)

int numX = ReadData("Введите координату X");
int numY = ReadData("Введите координату Y");

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод определяет четверть по координатам
void PrintTest()
{
    if (numX > 0 && numY > 0) Console.WriteLine("Точка в четверти 1");
    if (numX > 0 && numY < 0) Console.WriteLine("Точка в четверти 2");
    if (numX < 0 && numY < 0) Console.WriteLine("Точка в четверти 3");
    if (numX < 0 && numY > 0) Console.WriteLine("Точка в четверти 4");
}

PrintTest();



