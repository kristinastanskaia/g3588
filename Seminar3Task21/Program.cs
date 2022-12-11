// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве

int coorX1 = ReadData("Введите X координату первой точки");
int coorY1 = ReadData("Введите Y координату первой точки");
int coorZ1 = ReadData("Введите Z координату первой точки");
int coorX2 = ReadData("Введите X координату второй точки");
int coorY2 = ReadData("Введите Y координату второй точки");
int coorZ2 = ReadData("Введите Z координату первой точки");

double result = CalculateLenght(coorX1, coorY1, coorZ1, coorX2, coorY2, coorZ2);
PrintData("Расстояние между точками = ", result);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод делает рассчет
double CalculateLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return res;
}

//Метод выводит результат
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}
