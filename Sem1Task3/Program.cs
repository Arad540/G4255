string numLine = Console.ReadLine();
if(numLine!= null)
{
   int numN = int.Parse(numLine);
   int startNum = numN*(-1);
   string res = string.Empty;
   while (startNum<=numN)
   {

          res = res + startNum+" ";
          startNum++;

   }
   Console.WriteLine(res);


}
