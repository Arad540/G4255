
int ReadData (string message)
{
Console.WriteLine(message);
int res = int.Parse (Console.ReadLine () ?? "0");
return res;

}
Boolean PalTst (int num)
{
   bool res = false;
   int r1 = num/10000;
   int r5 = num%10;
   int r2 = (num/1000)%10;
   int r4 = (num/10)%10;   

   if (r1 == r5 && r2 == r4) 
   return res;

}
int num = ReadData("Put number ");

Console.WriteLine("Lengs between to points is: " + PalTst (num));
