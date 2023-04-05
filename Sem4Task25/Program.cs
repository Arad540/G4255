int ReadNum1(string message)
{
    Console.WriteLine(message);
    int num1 = int.Parse(Console.ReadLine() ?? "0");
    return num1;
}
int ReadNum2(string message)
{
    Console.WriteLine(message);
    int num2 = int.Parse(Console.ReadLine() ?? "0");
    return num2;
}
void PrintResult(string message, int res)
{
     Console.WriteLine(message+res);
}
int CountDigit(int Number1, int Number2)
{
    int res2 = 1;
    int result = 1;
    while(result<=Number2)
    {
      result=result +1;
       res2 = Number1*res2;              
    }


    return res2 ;
}
int numberA = ReadNum1("put number 1: ");
int numberB = ReadNum1("put number 2: ");
int res2 = CountDigit (numberA, numberB );
PrintResult ("pow number 1 on number2: ",(int)res2);