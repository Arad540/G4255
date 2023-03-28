int num = int.Parse(Console.ReadLine()??"0");

int res = num;

if (num <100 )

Console.Write("The 3rd number does not exist");

else
{
    

while (res >= 1000)
{
    res = res /10;
 
}

res = res%10;
}
Console.Write( res );

