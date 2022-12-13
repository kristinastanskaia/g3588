// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе

int num = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res1 = VariantSimple(num);
Console.WriteLine(DateTime.Now - d1);
PrintData("в этом числе цифр(симпл): " + res1);

DateTime d2 = DateTime.Now;
int res2 = VariantString(num);
Console.WriteLine(DateTime.Now - d2);
PrintData("в этом числе цифр(стринг): " + res2);

DateTime d3 = DateTime.Now;
int res3 = VariantLogarifm(num);
Console.WriteLine(DateTime.Now - d3);
PrintData("в этом числе цифр(логарифм): " + res3);


int VariantSimple(int num)
{
    int res = 0;
    while (num > 0)
    {
        res++;
        num = num / 10;
    }
    return res;
}

int VariantString(int num)
{
    int res = num.ToString().Length;
    return res;
}

int VariantLogarifm(int num)
{
    int res = (int)Math.Log10(num) + 1;
    return res;
}

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