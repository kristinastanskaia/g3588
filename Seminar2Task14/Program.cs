//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

int firstNumber = int.Parse(Console.ReadLine()??"0");

int result1 = firstNumber % 7;
int result2 = firstNumber % 23;

if ((result1 == 0) && (result2== 0))
//if (result1 + result2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
