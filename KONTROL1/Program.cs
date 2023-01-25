

int number = ReadData("Сколько строк вы хотите ввести?");
string[] arr = GenArray(number);
PrintData("Сгенерированный массив из введенных строк: ", arr);
string[] arr1 = BuildArr(arr);
Console.WriteLine();
PrintData("Новый массив: ", arr1);


//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, считывающий данные, введенные пользователем
string ReadData1(string msg)
{
    Console.WriteLine(msg);
    return (Console.ReadLine() ?? "0");
}

// Метод генерирует массив из введенных пользователем строк
string[] GenArray(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = ReadData1("Введите данные: ");
    }
    return arr;
}

// Метод выводит данные пользователю
void PrintData(string res, string[] arr)
{
    Console.WriteLine(res);
    PrintArray(arr);
}

// Метод печатает одномерный массив
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод проверяет кол-во символов в каждой строчке массива (либо удаляет либо оставляет ее)
string[] BuildArr(string[] arr)
{
    string[] outArr = new string[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            outArr[i] = arr[i];
        }
    }
    return outArr;
}







// // Метод 
// string[] BuildArr(string[] arr)
// {
//     string[] outArr = new string[];

//     for (int i = 0; i < arr.Length; i++)
//     {
//         outArr[i] = arr[i];
//     }
//     return outArr;
// }



