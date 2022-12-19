// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] testArr = GenArray(123, -100, 100);
Print1DArr(testArr);
int num = CountElement(testArr, 10, 99);
Console.WriteLine();
PrintData("ответ: ", num);


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

//Метод выводит результат
void PrintData(string msg, int res)
{
    Console.Write(msg + res);
}

// Метод подсчитывает кол-во подходящих элементов массива
int CountElement(int[] arr, int min, int max)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min && arr[i] < max)
        {
            res++;
        }
    }
    return res;
}
