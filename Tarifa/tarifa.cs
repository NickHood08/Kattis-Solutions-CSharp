using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numMB = Int32.Parse(Console.ReadLine());
        int numMonths = Int32.Parse(Console.ReadLine());
        int mbTracker = 0;
        for(int i = 0; i < numMonths; i++)
        {
            int mbUsed = Int32.Parse(Console.ReadLine());
            mbTracker += numMB - mbUsed;
        }
        mbTracker += numMB;
        Console.WriteLine(mbTracker);
    }
}
