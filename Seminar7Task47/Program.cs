//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Решение
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
Console.WriteLine();
double[,] arr2D = Fill2DArr(row, column, 1, 100);
Print2DArray(arr2D);

//Метод, считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печатающий двумерный массив
void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write((matrix[i, j]) + "          ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

// Метод генерации и заполнение двумерного массива вещественными числами
double[,] Fill2DArr(int countRow, int countColumn, int topBorder, int downBorder)
{
    double[,] arr = new double[countRow, countColumn];
    Random random = new Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = Math.Round(random.NextDouble() + random.Next(topBorder, downBorder), 2);
        }
    }
    return arr;
}
