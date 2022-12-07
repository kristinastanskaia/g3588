
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

//ВАРИАНТ 2

int num = int.Parse(Console.ReadLine() ?? "0");
if (num > 0 && num < 8)
{
    string[] week = new string[7];

    week[0] = "рабочий день";
    week[1] = "рабочий день";
    week[2] = "рабочий день";
    week[3] = "рабочий день";
    week[4] = "рабочий день";
    week[5] = "выходной день";
    week[6] = "выходной день";
    Console.WriteLine(week[num - 1]);
}
else
{
    Console.WriteLine("Это не день недели!");
}


