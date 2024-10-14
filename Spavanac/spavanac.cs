using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int hour = Int32.Parse(input.Split(" ")[0]);
        int min = Int32.Parse(input.Split(" ")[1]);
        if(min < 45 && hour >= 1)
        {
            hour -= 1;
        }
        else if(min < 45 && hour == 0)
        {
            hour = 23;
        }
        if(min >= 45)
        {
            min -= 45;
        }
        else if(min < 45)
        {
            min = (60 + (min - 45));
        }
        Console.WriteLine(hour + " " + min);
    }
}
