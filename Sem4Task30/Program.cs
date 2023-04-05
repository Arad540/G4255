using System;
Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

void Print1DArr(int[] arr)
{
     Console.Write("[");
     for (int i =0; i <arr.Length -1; i++)
     {
          Console.Write(arr[i]+",");
     } 
     Console.WriteLine(arr[arr.Length-1]+"]");              
}

int [] Gen1DArr (int len, int top, int but)
{
       int [] res = new int[len];
       for (int i=0; i<len; i++)
       {
            res[i] new Random().next (but , top + 1);      
       }             
}

