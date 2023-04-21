using System.Data;
// Read data method
Console.Clear();
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}


// Call method sum m to n
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

// Mwthid sum of m to n
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

int mNew = ReadData("Put lower number: ");
int nNew = ReadData("Put bigger number: ");
SumFromMToN(mNew,nNew);

