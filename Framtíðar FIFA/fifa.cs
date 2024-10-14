using System;

public class Program
{
    public static void Main(string[] args)
    {
        int sleepYear = 2022;
        
        int sleepImprovements = Int32.Parse(Console.ReadLine());
        int gameImprovements = Int32.Parse(Console.ReadLine());
        
        int yearsAsleep = sleepImprovements / gameImprovements;
        
        int newYear = sleepYear + yearsAsleep;
        Console.WriteLine(newYear);
    }
}
