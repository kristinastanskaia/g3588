// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Решение
int row = ReadData("Введите количество строк в массиве: ");
int column = ReadData("Введите количество столбцов в массиве: ");
int rowPoz = ReadData("Введите позицию искомого элемента в строке массива: ");
int columnPoz = ReadData("Введите позицию искомого элемента в столбце массива: ");
int[,] arr2D = Fill2DArr(row, column, 1, 100);
Print2DArray(arr2D);
SearchElem(arr2D, rowPoz, columnPoz);

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

// Метод поиска элемента по позиции в массиве
void SearchElem(int[,] arr, int x, int y)
{
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    {
        Console.WriteLine("Искомый элемент: " + (arr[x, y]));
    }
    else Console.WriteLine("Такого элемента в массиве нет!");
}
