// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Решение
int row = ReadData("Введите количество строк в массиве: ");
int column = ReadData("Введите количество столбцов в массиве: ");
int[,] arr2D = Fill2DArr(row, column, 1, 10);
Print2DArray(arr2D);
double[] newArr = AverageCol(arr2D, row, column);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
Print1DArr(newArr);

//Метод, считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод печатающий двумерный массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "        ".Substring(matrix[i, j].ToString().Length));
        }
        Console.WriteLine();
    }
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArr(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод печатает одномерный массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ";   ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод считает среднее арифметическое по столбцам
double[] AverageCol(int[,] arr, int i, int j)
{
    double[] aver = new double[arr.GetLength(1)];
    for (j = 0; j < arr.GetLength(1); j++)
    {
        for (i = 0; i < arr.GetLength(0); i++)
        {
            aver[j] += arr[i, j];
        }
        aver[j] = aver[j] / arr.GetLength(0);
    }
    return aver;
}

