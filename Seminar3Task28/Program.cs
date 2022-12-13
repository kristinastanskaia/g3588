// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

// Подключили большие числа
using System.Numerics;

int num = ReadData("Введите число N: ");
BigInteger res = CalcFactor(num);
PrintData("Произведение чисел от 1 до N: " + res);

BigInteger CalcFactor(int num)
{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}