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
