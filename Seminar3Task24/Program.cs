// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

int numA = ReadData("Введите число A: ");

DateTime d1 = DateTime.Now;
int res1 = Summa(numA);
Console.WriteLine(DateTime.Now - d1);
PrintData("Сумма чисел от 1 до А равна (простой метод): " + res1);

DateTime d2 = DateTime.Now;
int res2 = SumGausse(numA);
Console.WriteLine(DateTime.Now - d2);
PrintData("Сумма чисел от 1 до А равна (метод Гаусса): " + res2);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод делает подсчет суммы чисел
int Summa(int num)
{
    int sumNumbers = 0;
    for (int i = 1; i <= num; i++)
    {
        sumNumbers += i;
    }
    return sumNumbers;
}

//  Метод Гаусса
int SumGausse(int numA)
{
    int sumNumbers = 0;
    sumNumbers = ((1 + numA) * numA) / 2;
    return sumNumbers;
}