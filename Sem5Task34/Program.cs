
Console.Clear();

int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


//Print array method
void Print1Darray(int []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}

//filling out array randomly 

int[] Gen1Darray(int len, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}

//Method sorting  
// int[] SortArray(int[] arr)
// {

// int temp = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     for (int sort = 0; sort < arr.Length - 1; sort++)
//     {
//         if (arr[sort] > arr[sort + 1])
//         {
//             temp = arr[sort + 1];
//             arr[sort + 1] = arr[sort];
//             arr[sort] = temp;
//         }       
//     }   
//     Console.Write("{0} ", arr[i]);  
    
// }
// return arr;
// }
 
 //Metho counting even numbers 
 int EvenCount (int[] arr)
{
 int res = 0;
 for (int i = 0; i<arr.Length; i++)
 {
      if (arr[i]%2 == 0)
      {
          res++;          
      }

 }
 return res;
}
int lenArr = ReadData("Put massive length: ");
int[] arr = Gen1Darray(lenArr,100,999);
//int [] arr2 = SortArray(int[] arr);
Print1Darray(arr);
Console.WriteLine("");
Console.WriteLine("count of even numbers " + EvenCount(arr));
Console.WriteLine("");
