// Напишите программу замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

int[] testArr = GenArray(10, -9, 9);
Print1DArr(testArr);
int[] newArr = InverseArr(testArr);
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

// Метод инвертирует массив
int[] InverseArr(int[] arr)
{
    int[] outArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i] * (-1);
    }
    return outArr;
}