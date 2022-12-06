
//Получаем новое случайное число
int num = new Random().Next(100, 1000);

//Выводим данные в конслоь
Console.WriteLine(num);

//Определяем переменные
//int a = num / 100;
//int b = num % 10;
int res = (num / 100) * 10 + (num % 10);

//Выводим данные в конслоь
Console.WriteLine(res);
