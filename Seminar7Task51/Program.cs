// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали c индексами (0,0); (1;1) и т.д.

// Решение
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
Console.WriteLine();
int[,] arr2D = Fill2DArr(row, column, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
PrintData("Сумма элементов на главной диагонали равна: ", CalcDiag(arr2D));


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

// Метод, высчитывающий сумму элементов по диагонали
int CalcDiag(int[,] arr)
{
    int res = 0;
    int min = arr.GetLength(0) < arr.GetLength(1) ?
    arr.GetLength(0) : arr.GetLength(1);
    for (int i = 0; i < min; i++)
    {
        res += arr[i, i];
    }
    return res;
}

//Метод, выводящий на печать данные пользователю
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

