
Console.Clear();


int ReadData(string message)
{
    Console.WriteLine(message);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}


string LineGen(int num, int pow)
{
    string res = "";
    for (int i = 1; i <= num; i++)
    {
        res += Math.Pow(i, pow) + " ";
    }
    return res;
}

int numN = ReadData("Введите чило N: ");
int x1 = 0;
int x2 = 0;
int x3 = 0;
int y1 = 2;
int y2 = 4;
int y3 = 6;
int res1 = 0;
int res2 = 0;
int res3 = 0;
while (x1<(numN*3))
{
    x1 = x1 +1;
    x2 = x2 +1;
    x3 = x3 +1;
    res1 = x1;
    res2 = x2; 
    res3 = x3;
    Console.SetCursorPosition(res1,y1);
    Console.WriteLine("-");
    Console.WriteLine(" "+LineGen(numN,1));
    Console.SetCursorPosition(res2,y2);
    Console.WriteLine("-");
    Console.WriteLine(" "+LineGen(numN,3));
    Console.SetCursorPosition(res3,y3);
    Console.WriteLine("-");
    
}



