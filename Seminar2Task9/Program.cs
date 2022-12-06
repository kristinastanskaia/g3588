
    //Создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

    //Получаем новое случайное число
int number = numberSintezator.Next(1,100);

    //Выводим данные в конслоь
Console.WriteLine(number);

    //Вариант 1
    //Получаем первое и второе число по отдельности
int firstNumber = number/10;
int secondNumber = number%10;
    //Сравниваем числа
if(firstNumber>secondNumber)
{
    //Выводим данные в консоль
    Console.WriteLine(firstNumber);
}
else
{
    //Выводим данные в консоль
    Console.WriteLine(secondNumber);
}

