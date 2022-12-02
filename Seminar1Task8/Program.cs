string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int startNumber = 2;
    string outLine = string.Empty;
    int chek = inputNumber % 2;

    while (startNumber < inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber = startNumber + 2;
    }
    if (chek == 0)
    {
        outLine = outLine + inputNumber;
    }
    Console.WriteLine(outLine);
}