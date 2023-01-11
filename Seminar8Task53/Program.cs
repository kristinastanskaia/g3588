// Задайте двумерный массив и напишите программу которая поменяет местами первую и последню строчку этого массива

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Change2DArray(int[,] matr)
{
    int temp=0;
    for(int i=0;i<matr.GetLength(1);i++)
    {
        temp=matr[0,i];
        matr[0,i]=matr[matr.GetLength(0)-1,i];
        matr[matr.GetLength(0)-1,i] = temp;
    }
    // temp = 1
    // 7 2 3
    // 4 5 6
    // 1 8 9
}

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);

Change2DArray(matrix);
Print2DArray(matrix);
