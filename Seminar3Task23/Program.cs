// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N


//Получаем число от пользователя
int numN = ReadData("Введите число N: ");
//Собираем первую строчку, ряд цифр и выводи ее
String outline = LineBilder(numN, 1);
PrintData("", outline);
//Собираем вторую строчку, ряд кубов и выводи ее
outline = LineBilder(numN, 3);
PrintData("", outline);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод собирает строчку
string LineBilder(int N, int pow)
{
    string line = String.Empty;
    for (int i = 1; i < N; i++)
    {
        line = line  +  Math.Pow(i, pow) + " ";
    }
    line = line + Math.Pow(N, pow);
    return line;
}

//Метод выводит результат
void PrintData(string msg, string res)
{
    Console.WriteLine(msg + res);
}
