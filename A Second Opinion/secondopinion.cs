using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strSeconds = Console.ReadLine();
        int totalSeconds = Int32.Parse(strSeconds);
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        
        hours = (totalSeconds / 60) / 60;
        minutes = (totalSeconds / 60) % 60;
        seconds = totalSeconds % 60;
        
        Console.WriteLine(hours + " : " + minutes + " : " + seconds);
    }
}
