//Вариант 2

System.Random numberSintezator = new System.Random();

char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();

Console.WriteLine(digits);

int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

Console.WriteLine(resultNumber);
