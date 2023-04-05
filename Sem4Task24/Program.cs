//Напишите программу, которая принимает на вход
//число (А) и выдаёт сумму чисел от 1 до А.
Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
void PrintResult(string message, long res)
{
     Console.WriteLine(message+res);
}
long Sumsimple (int numA)
{
     long sum = 0;
     for (int i = 1; i<numA; i++)
     {
          sum+=i;
          //sum=sum+1          
     }


     return sum;
}
long SumGauss

int numberA = ReadData("put number a: ");
long res1 = Sumsimple (numberA );
PrintResult ("Sum numbers of 1-a:",(int)res1);

