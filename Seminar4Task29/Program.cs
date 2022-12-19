// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 


int arrLen = ReadData("Введите длину масива: ");
int numMin = ReadData("Введите значение минимального элемента: ");
int numMax = ReadData("Введите значение максимального элемента: ");
int[] arr = GenArray(arrLen, numMin, numMax);
PrintData("Сгенерированный массив ", arr);

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
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

//Метод выводит результат
void PrintData(string res, int[] arr)
{
    Console.Write(res);
    PrintArray(arr);
}

//Метод печатает массив
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
