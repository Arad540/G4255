//Задача №9
//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

System.Random numSintezator = new Random();

//1 method

int rndNum = numSintezator.Next(10,100);
Console.Write(rndNum);
//short firstNum = rndNum/10;
//short secondNum = rndNum%10;
int firstNum = rndNum/10;
int secondNum = rndNum%10;
if(firstNum>secondNum )
{
Console.WriteLine("First number in bigger "+ firstNum + "second "+ secondNum );
}
else
{
      Console.WriteLine(secondNum);              
}

