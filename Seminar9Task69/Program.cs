//==========================================
//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//==========================================

int numberA = ReadData("Enter number A:");
int numberB = ReadData("Enter number B:");

long res1 =0;
long res2 =0;
double res3 =0;
DateTime d1 = DateTime.Now;
res1 = RecPow(numberA,numberB);
PrintResult("Решение RecPow" + (DateTime.Now - d1));

DateTime d2 = DateTime.Now;
res2 = MyPow(numberA,numberB);
PrintResult("Решение MyPow" + (DateTime.Now - d2));

DateTime d3 = DateTime.Now;
res3 = Math.Pow(numberA,numberB);
PrintResult("Решение Math.Pow" + (DateTime.Now - d3));

PrintResult(res1.ToString());
PrintResult(res2.ToString());
PrintResult(res3.ToString());

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

long RecPow(int a,int b)
{
    if (b<= 1) return a;
    return a * RecPow(a,b-1);
}

long MyPow(int a,int b)
{
    if(b==2)return a*a;
    if(b==1)return a;

    if(b%2==0)
    {
       return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
       return MyPow(a,b/2)*MyPow(a,b/2+1);
    }
}
