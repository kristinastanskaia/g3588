// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод выводит результат
void PrintResult(string prefix, int a)
{
    Console.WriteLine(prefix + a);
}

// Метод генерит числовой ряд и считает сумму (рекурсия) 
int SummMN(int M, int N)
{

    if (M >= N) return N;
    int outRes = M + SummMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int result = number1 < number2 ? SummMN(number1, number2) : SummMN(number2, number1);
PrintResult("Сумма элементов в промежутке между числами = ", result);