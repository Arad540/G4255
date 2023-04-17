using System.Reflection.Metadata.Ecma335;
Console.Clear();

//Readdata method
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Generator array method
int[,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}
//Print arrey metho
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
//Method check indexes
void CheckElmnt(int [,] arr, int row, int cloum )
{
                  
  if (row> arr.GetLength(0)|| cloum> arr.GetLength (1))
  {
       Console.WriteLine("There is not such element");             
  }
  else
  {
        Console.Write("The element of the selected indexes is: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(arr[row ,cloum]);
        

  }

}
void PrintGreen2DArray(int[,] arr, int x, int y)
{

 ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Green};
 Console.Write(arr);
Console.ForegroundColor = col[arr [x,y]];
            
}


int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2DArray(row,col,10,99);
Priny2DArray(arr2D);
Console.WriteLine();
int RowIndex = ReadData("Put the row index: ");
int columeIndex = ReadData("Put the colume index: ");
Console.WriteLine();
CheckElmnt(arr2D, RowIndex,columeIndex);
Console.WriteLine();
int a = RowIndex;
int b = columeIndex;
PrintGreen2DArray(arr2D,a,b);