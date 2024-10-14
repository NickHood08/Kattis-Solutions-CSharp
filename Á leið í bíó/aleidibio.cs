using System;

public class Program
{
    public static void Main(string[] args)
    {
        int minToArnar = Int32.Parse(Console.ReadLine());
        int minToCinema = Int32.Parse(Console.ReadLine());
        int minShowStart = Int32.Parse(Console.ReadLine());
        int timeToLeave = minShowStart - (minToArnar + minToCinema);
        Console.WriteLine(timeToLeave);
    }
}
