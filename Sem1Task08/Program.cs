string numLine = Console.ReadLine();
if(numLine!= null)
{
   int numN = int.Parse(numLine);
   int startNum = 1;

   while (startNum<=numN)
   {
          if(startNum%2 ==0)
          {
             Console.Write(startNum+" ");
          }
          startNum++;
   }
   
}