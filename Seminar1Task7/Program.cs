//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает последнюю цифру этого числа.

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int lastDigit = inputNumber % 10;

    Console.WriteLine(lastDigit);
}
