//Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

//Получаем новое случайное число
int num = new Random().Next(100, 1000);

//Выводим данные в конслоь
Console.WriteLine(num);

string value = num.ToString();

char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray [0] + "" + numberArray [2]);
