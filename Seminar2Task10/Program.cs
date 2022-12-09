//Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает вторую цифру этого числа.

int number = int.Parse(Console.ReadLine() ?? "0");

if (number < 1000 && number > 99)
{

    string value = number.ToString();

    char[] numberArray = value.ToCharArray();

    Console.WriteLine(numberArray[1] + " - вторая цифра этого числа");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}

