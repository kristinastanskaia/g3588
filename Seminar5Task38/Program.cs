// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

double[] testArr = GenArray(4, 0, 10);
Print1DArr(testArr);
double min = double.MaxValue;
double max = double.MinValue;
MinMax(testArr);
PrintData("Разница между максимальным и минимальным элементом равна: ", (max - min));


// Метод создает массив вещественных чисел
double[] GenArray(int num, double min, double max)
{
    Random rnd = new Random();
    double[] arr = new double[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = rnd.NextDouble()*10;
    }
    return arr;
}

// Метод печатает массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод находит минимальный и максимальный элемент
void MinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
}

//Метод выводит результат
void PrintData(string msg, double res)
{
    Console.Write(msg + res);
}