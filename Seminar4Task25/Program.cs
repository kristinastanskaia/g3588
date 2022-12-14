// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

// Подключили большие числа
using System.Numerics;
int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
BigInteger res = Multiplication(numA, numB);
PrintData("A ^ B = " + res);

// Метод возводит А в степень В
BigInteger Multiplication(int A, int B)
{
    BigInteger res = 1;
    for (int i = 1; i <= B; i++)
    {
        res = res * A;
    }
    return res;
}

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат
void PrintData(string msg)
{
    Console.WriteLine(msg);
}