
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
//Mthod sum event element in array 
int SunEventElm(int[] arr)
{
     int sum = 0;
     for (int i=0; i<arr.Length;i=i+2)
     {
         if(i%2==0)
         {
            sum+=arr[i];
         }           
     }
        return sum;             
}
int lenArr = ReadData("Put massive length: ");
int[] arr = Gen1Darray(lenArr,100,999);
Print1Darray(arr);
Console.WriteLine("");
Console.WriteLine("count of even numbers " + SunEventElm(arr));
Console.WriteLine("");