// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int number = ReadData("Сколько чисел вы хотите ввести?");
int res = CountPosNum(number);
PrintData("Вы ввели " + res + " числа больше 0");


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

// Метод подсчитывающий сколько чисел больше 0 ввел пользователь
int CountPosNum(int N)
{
    int res = 0;
    while (N > 0)
    {
        if (ReadData("Введите число") > 0) res++;
        N = N - 1;
    }
    return res;
}