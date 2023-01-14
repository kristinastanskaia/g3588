// задайте значение  n и m, напишите программу которая найдет все 
// натуральные элементы в промежутке от m до n


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод выводит результат
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Метод генерит числовой ряд (рекурсия)
string RecMN(int M, int N)
{
    string outRes = string.Empty;
    if (M >= N) return outRes + N;
    outRes = M + " " + RecMN(M + 1, N);
    return outRes;
}

int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
string resultLine = number1 < number2 ? RecMN(number1, number2) : RecMN(number2, number1);
PrintResult(resultLine);