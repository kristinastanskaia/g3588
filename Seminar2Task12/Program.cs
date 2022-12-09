//Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если второе число некратно
//первому, то программа выводит о статок от деления .

int firstNumber = int.Parse(Console.ReadLine()??"0");
int secondNumber = int.Parse(Console.ReadLine()??"0");

int result = secondNumber % firstNumber;

if (result == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число делится на первое с остатком " + result);
}
