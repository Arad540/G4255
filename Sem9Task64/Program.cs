Console.Write("Put your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);

//Methid of natural number deccending 
void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}