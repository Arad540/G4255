Console.WriteLine("Put your number: ");
string? num = Console.ReadLine();

if (num!=null)
{
   int intNumber = int.Parse(num);
   int res = intNumber % 10;
   Console.Write(res);

}


