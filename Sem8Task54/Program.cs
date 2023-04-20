
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
//The method of sorting of row to lower  
void SortToLowRow(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
//method sorting of columns
void SortToLowCol(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(0) - 1; k++)
            {
                if (array[k, j] < array[k + 1 , j])
                {
                    int temp = array[k + 1 , j];
                    array[k + 1 , j] = array[k,j];
                    array[k,j] = temp;
                }
            }
        }
    }
}



int row = ReadData("Put count of row: ");
int col = ReadData("Put count of column: ");
int[,] arr2D = Gen2DArray(row,col,10,99);
Priny2DArray(arr2D);
SortToLowRow(arr2D);
Console.WriteLine();
Console.WriteLine("Sorted arrey in row ---------------------------------");
Console.WriteLine();
Priny2DArray(arr2D);
Console.WriteLine();

Console.WriteLine("Sorted arrey in columns ---------------------------------");
SortToLowCol(arr2D);
Console.WriteLine();
Priny2DArray(arr2D);


