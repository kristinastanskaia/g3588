// Напишите программу которая перевернет одномерный массив.
// Последний станет первым, первый-последним.

int[] arr = GenArray(20,1,100);
Console.WriteLine("Исходный массив");
Print1DArr(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый массив перевернутый SwapNewArray методом");
Print1DArr(copyArr);

int[] copyArrTwo = SwapArray(arr);
Console.WriteLine("Исходный массив перевернутый SwapArray методом");
Print1DArr(copyArrTwo);

// Метод, генерирующий массив
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод простого разворота массива
int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for(int i =0;i<arr.Length/2;i++)
    {
        bufElement = arr[arr.Length-1-i];
        arr[arr.Length-1-i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}

// Метод, создающий новый массив из исходного
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i =0;i<arr.Length;i++)
    {
        outArr[i] = arr[arr.Length-1-i];
    }
    return outArr;
}