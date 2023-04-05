// int ReadNum1(string message)
// {
//     Console.WriteLine(message);
//     int num1 = int.Parse(Console.ReadLine() ?? "0");
//     return num1;
// }

// string intToChar (string arr[], int num)
// {
// char [] arr1 = num.toChararrey();
// return arr1;
// }

string? num = Console.ReadLine();

char[] arr = num.ToCharArray();
Console.WriteLine(arr.Length);

int i = 0;
int res = 0;

while ( i < arr.Length)
{

res = res + arr[i] ;
i++;
Console.WriteLine(res);

}


