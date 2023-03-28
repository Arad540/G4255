int num = int.Parse(Console.ReadLine()??"0");

int Numthird = num%1000;
int NumCheck = num/1000;

if (NumCheck > 0)
{
    int secondNum = Numthird / 100;
    Console.WriteLine("secondNum);

}
else
{  
    Console.WriteLine(" number contanis less that 3 digits ");
}
