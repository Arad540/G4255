// Read data method
Console.Clear();
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Calling methid Akkerman
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// Akkerman method
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

int mNew = ReadData("Put lower number: ");
int nNew = ReadData("Put bigger number: ");
AkkermanFunction(mNew,nNew);
