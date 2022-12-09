//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

// //ВАРИАНТ 1
// int num = int.Parse(Console.ReadLine() ?? "0");

// if (num > 0 && num < 8)
// {
//     if (num < 6)
//     {
//         Console.WriteLine("Это рабочий день");
//     }
//     else
//     {
//         Console.WriteLine("Это выходной день");
//     }
// }
// else
// {
//     Console.WriteLine("Это не день недели!");
// }

// //ВАРИАНТ 2

// int num = int.Parse(Console.ReadLine() ?? "0");
// if (num > 0 && num < 8)
// {
//     string[] week = new string[7];

//     week[0] = "рабочий день";
//     week[1] = "рабочий день";
//     week[2] = "рабочий день";
//     week[3] = "рабочий день";
//     week[4] = "рабочий день";
//     week[5] = "выходной день";
//     week[6] = "выходной день";
//     Console.WriteLine(week[num - 1]);
// }
// else
// {
//     Console.WriteLine("Это не день недели!");
// }

//ВАРИАНТ 3

int num = int.Parse(Console.ReadLine() ?? "0");
if (num > 0 && num < 8)
{
    Dictionary<int, string> dict = new Dictionary<int, string>
    {
        {1, "рабочий день"},
        {2, "рабочий день"},
        {3, "рабочий день"},
        {4, "рабочий день"},
        {5, "рабочий день"},
        {6, "выходной день"},
        {7, "выходной день"},
    };
    Console.WriteLine(dict[num]);
}
else
{
    Console.WriteLine("Это не день недели!");
}
