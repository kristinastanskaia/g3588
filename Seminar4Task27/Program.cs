// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе

int num = ReadData("Введите число: ");
int res = Sumofdigits(num);
PrintData("Сумма цифр в данном числе = " + res);

// Метод высчитывает сумму цифр в числе
int Sumofdigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + (num % 10);
        num = num / 10;
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