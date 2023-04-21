
using System.Runtime.Intrinsics.X86;
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
//multiply  arreys method

int [,] MultArrays (int [,] arrOne, int [,] arrTwo)
{
int[,] result = new int[arrOne.GetLength(0), arrTwo.GetLength(1)];

if (arrOne.GetLength(0) !=arrTwo.GetLength(1))
{
    Console.WriteLine(" These arrays can not be multified ");
    
}
else{
    
for (int i = 0; i < arrOne.GetLength(0); i++)
{
    for (int j = 0; j < arrTwo.GetLength(1); j++)
    {
       
        for (int k = 0; k < arrOne.GetLength(1); k++)
        {
            result[i,j] += arrOne[i, k] * arrOne[k, j];
        }
    }
}

}
 return result;  
}

// calling methids and run program 
int rows = ReadData("Put count of row: ");
int columns = ReadData("Put count of column: ");

int[,] array = Gen2DArray(rows,columns,1,10);
Priny2DArray(array);
Console.WriteLine("-------------");
int[,] secondArray = Gen2DArray(rows,columns,1,10);
Priny2DArray(secondArray);
Console.WriteLine("-------------");
int[,] arrRes = MultArrays(array, secondArray);
Console.WriteLine("Multifyed arrays: ");
Priny2DArray(arrRes);



