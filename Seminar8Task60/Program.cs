//.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


// int GenNum(List<int> num)
// {
//     int index = new Random().Next(0, num.Lenght);
//     int outNum = num[index];
//     num.Remove.add(index);
//     return outNum;
// }

// метод генерации и заполнение трехмерного массива
int[,,] Fill3DArr(int countRow, int countColumn, int list, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,,] array3D = new int[countRow, countColumn, list];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int l = 0; l < list; l++)
            {
                array3D[i, j, l] = rand.Next(topBorder, downBorder + 1);
            }
        }
    }
    return array3D;
}

// Метод печатающий трехмерный массив
void Print3DArr(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($" [ {matrix[i, j, l]} ] ({i} , {j} , {l})" + "        ".Substring(matrix[i, j, l].ToString().Length));
            }
            Console.WriteLine();
        }

    }
}


int row = ReadData("Введите первое значение координат трехмерного массива: ");
int column = ReadData("Введите второе значение координат трехмерного массива: ");
int list = ReadData("Введите третье значение координат трехмерного массива: ");
int[,,] matrix3D = Fill3DArr(row, column, list, 10, 99);
Print3DArr(matrix3D);

// List<int> num = new List();
// for (int i = 0; i < 90; i++) ;
// {
//     num.add(10 + i);
// }

