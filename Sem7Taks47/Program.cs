// Method putiing arrey elements
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Method of generation double arrey
double [,] Gen2DArray(int countRow, int countColumn, int minValue, int maxValue)
{
    double [,] arr = new double [countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 101) + new Random().NextDouble(), 2);
            
        }
    }
    return arr;
}
// Method of printing arrey
void Priny2DArray(double [,] arr)
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
            Console.Write(arr[i,j]+"\t ");
            Console.ResetColor();
        }
        Console.WriteLine("");
    }
}
int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
double [,] arr2D = Gen2DArray(row,col,10,99);
Priny2DArray(arr2D);
