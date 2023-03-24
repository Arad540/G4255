string? number = Console.ReadLine();

if (number!=null)
{
    int num = int.Parse(number);
    if ( num % 2 == 0)
    {
        Console.Write(num+" is even");          
    }
}
