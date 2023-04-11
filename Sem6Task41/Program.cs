Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


int PosValCout (int num)
{
    int count = 0;
    while (num>0) 

    {

        int val = ReadData ("put number pls " + num + ":");
        if (val>0) count++;
        num = num-1;
    }
    return count;

}



int numberA = ReadData("put count number: ");
int result = PosValCout (numberA);
Console.WriteLine("count of numbers bigger than 0: "+result);



