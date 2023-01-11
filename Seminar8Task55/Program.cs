// Задайте двумерный массив и напишите программу которая заменит строки на столбцы
// и если это невозможно  - программа должна вывести сообщение для пользователя


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

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
            Console.ForegroundColor = col[matrix[i,j]%15];
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


bool TTest(int[,]arr)
{
    if(arr.GetLength(0)==arr.GetLength(1)) 
    {
        return true;
    }
    else
    {
        Console.WriteLine("В данном массиве невозможно поменять столбцы и строки местами");
        return false;
    }
}

void TUpdate2DArray(int[,] arr)
{
    int temp=0;
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i+1; j < arr.GetLength(1); j++)
        {
            temp = arr[i,j];
            arr[i,j]=arr[j,i];
            arr[j,i]=temp;
        }
    }
}

int row = ReadData("Введите количество строк: ");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов: ");                           // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 1, 100);   
Print2DArrayColor(arr2D);    
Console.WriteLine();
if (TTest(arr2D)) TUpdate2DArray(arr2D);  
Print2DArrayColor(arr2D);