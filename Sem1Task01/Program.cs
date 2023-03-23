String? numLine1 = Console.ReadLine();
String? numLine2 = Console.ReadLine();

if(numLine1!=null && numLine2!=null)
{
   int num1 = int.Parse(numLine1);
   int num2 = int.Parse(numLine2);
   if (num1 == num2*num2)
   {
       Console.WriteLine("Первое число квадрат ДА"); 
   }
       else
       {
           Console.WriteLine("Первое число квадрат НЕТ");        
       }           
                    
}
