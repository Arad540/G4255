// Putting numbers 
int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}
double CalcLength3D(int x1, int x2, int y1,int y2, int z1, int z2)
{
     // return Math.Sqrt(Math.Pow((x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1)));
     return Math.Sqrt(((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)));
     

}
int x1 = ReadData("Put x1: ");
int x2 = ReadData("Put x2: ");
int y1 = ReadData("Put y1: ");
int y2 = ReadData("Put y2: ");
int z1 = ReadData("Put z1: ");
int z2 = ReadData("Put z2: ");

Console.WriteLine("Lengs between to points is: " + CalcLength3D(x1,x2,y1,y2,z1,z2));

