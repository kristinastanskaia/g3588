//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

void Test(int i, int j)
{
    bool res = (i / j == j);
    if (res == true) Console.WriteLine("число " + i + " является квадратом числа " + j);
    else Console.WriteLine("число " + i + " не является квадратом числа " + j);
}

int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = int.Parse(Console.ReadLine() ?? "0");

Test(num1, num2);
Test(num2, num1);
