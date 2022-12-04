string? inputLine = Console.ReadLine();     // Считываем данные с консоли

if (inputLine != null)      // Проверяем, чтобы данные были не пустыми
{
    int inputNumber = int.Parse(inputLine);     // Парсим введеное число
    int startNumber = 2;        // Вводим переменную, с которой начинается ряд четных чисел
    string outLine = string.Empty;      // Вводим переменную, которая накапливает ответ
    int chek = inputNumber % 2;     // Вводим переменную, равную остатку от деления на 2

    while (startNumber < inputNumber)       // Вводим условие цикла
    {
        outLine = outLine + startNumber + ",";     // Накапливаем ответ
        startNumber = startNumber + 2;
    }

    if (chek == 0)      //Проверяем, остаток от деления равен 0 (четное ли введеное число?)
    {
        outLine = outLine + inputNumber;        // Добавляем к ответу и введеное число
    }
    outLine = outLine.TrimEnd(',');            //Удаляем крайнюю запятую
    Console.WriteLine(outLine);
}
