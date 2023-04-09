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
double[] Gen1Darray(double len, double minValue, double maxValue)
{
    if (minValue > maxValue)
    {
        double buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    Random rnd = new Random();
    double [] arr = new double[(int) len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =  rnd.NextDouble(minValue, (maxValue + 1));
    }
    return arr;
}

//method difrrent min max
double DiffMinMax(double[ ] arr)
{
   double res =0;
   double min = double.MaxValue;
   double max = double.MinValue;
   for (int i = 0; i<arr.Length; i++)
   {
       if(min>arr[i]) min = arr[i]; 
       if(max>arr[i]) max = arr[i];               
   }
   res = max-min;
   return res;

}
// results 
int lenArr = ReadData("Put massive length: ");
int[] arr = Gen1Darray(lenArr,0,1);
Print1Darray(arr);