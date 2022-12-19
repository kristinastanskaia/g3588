// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.


int posetivSum = 0;
int negativSum = 0;

int[] testArr = GenArray(12, -9, 9);
NegativPosetivSum(testArr);
Print1DArr(testArr);
PrintData("Сумма положительных чисел в массиве: ", posetivSum);
PrintData("Сумма отрицательных чисел в массиве: ", negativSum);

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

//Метод выводит результат
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

// Метод считает сумму
void NegativPosetivSum(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            posetivSum += arr[i];
        }
        else
        {
            negativSum += arr[i];
        }
    }
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