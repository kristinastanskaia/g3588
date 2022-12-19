// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int[] testArr = GenArray(10, -9, 10);
Print1DArr(testArr);
int num = ReadData("Введите число: ");
int result = SearchElem(testArr, num);

if (result >= 0)
{
    PrintData("Элемент найден в позиции: " + result);
}
else
{
    PrintData("Элемент в массиве не найден!");
}


// Метод создает массив
int[] GenArray(int num, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

// Метод печатает одномерный массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод поиска элемента в массиве
int SearchElem(int[] arr, int element)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == element)
        {
            res = i;
            break;
        }
    }
    return res;
}

//Метод выводит результат
void PrintData(string res)
{
    Console.WriteLine(res);
}