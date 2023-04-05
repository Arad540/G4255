
Console.Clear();
Console.Write("Please put your number: ");

string? num = Console.ReadLine();
char[] arr = num.ToCharArray();
int i = 0;
int res = 0;
while ( i < arr.Length)
{
res = res + arr[i]-48 ;
i++;
}
Console.WriteLine("");
Console.WriteLine("Length of arrey: " + arr.Length);
Console.WriteLine("");
Console.WriteLine("Sum of length: " +res);
Console.WriteLine("");


