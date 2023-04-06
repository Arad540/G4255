using System.Numerics;

int ReadNum(string message)
{
    Console.WriteLine(message);
    int num1 = int.Parse(Console.ReadLine() ?? "0");
    return num1;
}

void PrintResult(string message, BigInteger res)
{
     Console.WriteLine(message+res);
}
BigInteger CountDigit(int Number1, int Number2)
{
    BigInteger res2 = 1;
    BigInteger result = 1;
    while(result<=Number2)
    {
    result=result +1;
    res2 = Number1*res2;              
    }

    return res2 ;
}
int numberA = ReadNum("put number 1: ");
int numberB = ReadNum("put number 2: ");
BigInteger res2 = CountDigit (numberA, numberB );
PrintResult ("power number 1 on number2: ", res2);

