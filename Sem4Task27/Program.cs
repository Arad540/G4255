

string? num = Console.ReadLine();
char[] arr = num.ToCharArray();
//Console.WriteLine(arr.Length);
int i = 0;
int res = 0;
while ( i < arr.Length)
{
res = res + arr[i]-48 ;
i++;
}Console.WriteLine("sum of length " +res);


