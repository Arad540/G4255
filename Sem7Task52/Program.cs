//Putting data
Console.Clear();
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//array generation method
int[,] Gen2DArray(int countRow, int countColumn, int but, int top)
{
    if (but > top)
    {
        int buf = top;
        top = but;
        but = buf;
    }
    int[,] res = new int[countRow,countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for(int j=0; j < countColumn; j++)
        {
            res[i,j] = new Random().Next(but, top + 1);
        }
    }
    return res;
}

//Array filler method
int[,] FillNM2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = i+j;
        }
    }
    return arr;
}

//Print arrey method 2 dimentions 
void Print2DArray(int[,] arr)
{
//     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {
            //Console.ForegroundColor = col[new Random().Next(0,16)];
           Console.Write(arr[i,j]+"\t ");
            //Console.ResetColor();
        }
        Console.WriteLine("");
    }
}
double [] ColumnAvg (int [,] arr)
{
    double[ ] avg = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
         for(int i=0; i<arr.GetLength(0); i++)
         {
            avg[j] += arr[i,j];
         } 
         avg[j] = avg[j]/arr.GetLength(0);          
    } 
    return avg;               
}

//Print arrey method 1 dimention 
void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

void paintDiag (int [,] arr)
{
   //     ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for(int j=0; j < arr.GetLength(1); j++)
        {
            //Console.ForegroundColor = col[new Random().Next(0,16)];
           Console.Write(arr[i,j]+"\t ");
            //Console.ResetColor();
        }
        Console.WriteLine("");

} 

// Runung methods code
int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = new int[row,col];
int[,] arr = FillNM2DArr(arr2D);
Print2DArray(arr);
double [] avgRes =  ColumnAvg(arr2D);
Console.WriteLine();
Console.Write("avarage of columns: ");
Print1DArr(avgRes);
Console.WriteLine();

