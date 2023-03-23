Console.WriteLine("Put week day");
string? dayLine = Console.ReadLine();

if (dayLine!= null)
{
    string[] dayweek = new string[7];
    dayweek[0] = "Mon";
    dayweek[1] = "Tue";
    dayweek[2] = "Wed";
    dayweek[3] = "Thu";
    dayweek[4] = "Fri";
    dayweek[5] = "Sat";
    dayweek[6] = "Sun";
    int day = int.Parse(dayLine);
    Console.WriteLine(dayweek[day-1]);
}

