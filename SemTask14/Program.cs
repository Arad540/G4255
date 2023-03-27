//Задача №14
//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
int num = int.Parse(Console.ReadLine()??"0");
bool test1 = (num%7==0);
bool test2 = (num%23 == 0);
if (test1 && test2)
{
 Console.WriteLine("кратно  оно одновременно 7 и 23.");
}

else 
{
   Console.WriteLine("не кратно  оно одновременно 7 и 23.");
}