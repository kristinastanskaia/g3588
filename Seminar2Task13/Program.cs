//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

// //ВАРИАНТ 1

// int number = int.Parse(Console.ReadLine() ?? "0");
// if (number > 99)
// {
//     char[] numberArray = number.ToString().ToCharArray();
//     Console.WriteLine(numberArray[2] + " - третья цифра этого числа");
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет!");
// }



// //ВАРИАНТ 2

// int num = int.Parse(Console.ReadLine() ?? "0");    //Считываем данные с консоли и проверяем, что они не пустые

// //Вводим переменные
// int raz = 0;        //Переменная для определения кол-ва цифр в числе
// int dubler = num;   //Переменная, дублер начального числа
// int pozition = 3;   //Номер по порядку третьей цифры числа

// if (num > 99)                        //Проверяем, наше число трехзначное?
// {
//     if (num > 999)                   //Проверяем, наше  число четырехзначное?
//     {
//         while (dubler > 0)           //Находим кол-во цифр в числе, делением на 10 дублера нашего числа
//         {
//             dubler = dubler / 10;
//             raz = raz + 1;           //Подсчитываем кол-во цифр в числе
//         }
//         while (raz > pozition)      // Пока кол-во цифр больше 3, отсекаем по одной цифре с конца, делением на 10
//         {
//             num = num / 10;
//             raz = raz - 1;
//         }
//         Console.WriteLine("Третья цифра " + num % 10);  //Находим остаток от деления на 10 полученного трехзначного числа
//     }
//     else       //Наше число трехзначное, значит выводим остаток от деления на 10
//     {
//         Console.WriteLine("Третья цифра " + num % 10);
//     }
// }
// else         //Наше число не трехзначное!
// {
//     Console.WriteLine("Третьей цифры нет!");
// }

// //ВАРИАНТ 3

// int num = int.Parse(Console.ReadLine() ?? "0"); 

// if (num > 99)                       
// {
//     if (num > 999)                   
//     {
//         while (num > 999)         
//         {
//             num = num / 10;
//         }
//     }
//     Console.WriteLine("Третья цифра " + num % 10);
// }
// else         
// {
//     Console.WriteLine("Третьей цифры нет!");
// }

// //Вариант 4

// int num = int.Parse(Console.ReadLine() ?? "0");
// if (num > 99)
// {
//     int lenght = (int)Math.Log10(num) + 1;
//     int index = 3;

//     while (lenght > index)
//     {
//         num = num / 10;
//         lenght = lenght - 1;
//     }
//     Console.WriteLine("Третья цифра " + num % 10);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет!");
// }

//Вариант 5

int num = int.Parse(Console.ReadLine() ?? "0");
int pozition = 3;  //Позиция третьего числа

if (num > 99)
{
    int lenght = (int)Math.Log10(num) + 1;   //Находим кол-во цифр в числе
    int index = lenght - pozition;     //Находим разность всей длины до третьей позиции 
    num = num / Convert.ToInt32(Math.Pow(10, index));  //Отсекаем столько цифр с конца числа

    Console.WriteLine("Третья цифра " + num % 10);  //Находим остаток от деления на 10
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}
