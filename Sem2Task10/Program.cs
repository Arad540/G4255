Console.WriteLine("Please put number with 3 digits");
int number = int.Parse(Console.ReadLine()??"0");
number = number %100;
number = number/10;
Console.Write(number);
