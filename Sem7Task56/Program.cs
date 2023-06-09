﻿
// Read data method
Console.Clear();
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Generation method od arrey
int[,] Gen2DArray(int countRow, int countColumn,  int minValue, int maxValue)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return arr;
}
//Print method
void Priny2DArray(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write(arr[i,j]+" ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
//minimum sum arrey method
int minSumRarrey (int [,] arr) 

{
    int outN = 0;
    int MinSum = int.MaxValue; 
    

    for (int i=0; i<arr.GetLength(0); i++)
    {
        int sum = 0;
            for (int j=0; j<arr.GetLength(1); j++)
            {
                
                sum = sum + arr[i,j];
                
                if (sum<MinSum )
                {
                  MinSum = sum;
                  outN = i;

                }

            }

    }

    return outN;

}
// calling methids and run program 
int row = ReadData("Put count of row: ");
int col = ReadData("Put count of column: ");
int[,] arr2D = Gen2DArray(row,col,10,99);
Console.WriteLine("---------------------------------------------");
Priny2DArray(arr2D);

int res = minSumRarrey (arr2D);
Console.WriteLine("");
Console.WriteLine("Index number of the min sum of rows is: "+res);
Console.WriteLine("---------------------------------------------");



