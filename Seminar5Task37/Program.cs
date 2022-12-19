// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Заданный массив:");
int[] testArr = GenArray(10, -100, 100);
Print1DArr(testArr);
int[] newArr = ConvertArr(testArr);
Console.WriteLine("Новый массив:");
Print1DArr(newArr);

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

// Метод конвертирует массив (произведение чисел)
int[] ConvertArr(int[] arr)
{
    int[] outArr = new int[arr.Length / 2];
    for (int i = 0; i < (arr.Length / 2); i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return outArr;
}

