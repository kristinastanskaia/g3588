// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] testArr = GenArray(10, 1, 30);
Print1DArr(testArr);
int sum = SumOdd(testArr);
PrintData("Сумма элементов на нечетных позициях равна: ", sum);


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

// Метод считает сумму элементов на нечётных позициях в массиве
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res = res + arr[i];
        i = i + 2;
    }
    return res;
}

//Метод выводит результат
void PrintData(string msg, int res)
{
    Console.Write(msg + res);
}