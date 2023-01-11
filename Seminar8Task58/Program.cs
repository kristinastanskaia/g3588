// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать массива
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Генерируем двумерный массив, заполненный случайными числами
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
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

// Метод перемножает две матрицы
int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    if ((matrix1.GetLength(1) != matrix2.GetLength(1)) && (matrix1.GetLength(0) != matrix2.GetLength(1))) throw new Exception("Матрицы нельзя перемножить");
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }
    }
    return result;
}


int rowA = ReadData("Введите количество строк первой матрицы: ");
int columnA = ReadData("Введите количество столбцов первой матрицы: ");
int rowB = ReadData("Введите количество строк второй матрицы: ");
int columnB = ReadData("Введите количество столбцов второй матрицы: ");

int[,] arr2DA = Fill2DArray(rowA, columnA, 1, 9);
int[,] arr2DB = Fill2DArray(rowB, columnB, 1, 9);

Print2DArrayColor(arr2DA);
Console.WriteLine();
Print2DArrayColor(arr2DB);
Console.WriteLine("Новая матрица - произведение двух матриц: ");

int[,] newMatrix = MultiMatrix(arr2DA, arr2DB);
Print2DArrayColor(newMatrix);
