// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

//Получаем число от пользователя
int num = ReadData("Введите пятизначное число: ");
bool result = PalinTest(num);

if (num > 9999 && num < 100000)
{
    PrintData(result);
}
else Console.WriteLine("Это не пятизначное число!");

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод проверяет палиндром ли это
bool PalinTest(int num)
{
    result = (num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10);
    return result;
}

//Метод выводит результат
void PrintData(bool msg)
{
    if (result == true) Console.WriteLine("Число является палиндромом!");
    else Console.WriteLine("Число не является палиндромом");
}



