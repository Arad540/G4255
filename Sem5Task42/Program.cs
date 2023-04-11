Console.Clear();
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Метод, выводящий на печать массив
// void Print1DArr(double[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1] + "]");
// }

double[] Equip (int k1, int k2, int b1, int b2)

{
  double [] output = new double [2];


  double x  = (b2-b1)/(k1-k2 );
  double y = (k2*x) +b2;

  output [0] = x;
  output [1] = y;


return output;

}

int k1 = ReadData ("put k1: ");
int k2 = ReadData ("put k2: ");
int b1 = ReadData ("put b1: ");
int b2 = ReadData ("put b2: ");
double [] result = Equip( k1,  k2,  b1,  b2);
