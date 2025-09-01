using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        double altitude = double.Parse(input);
        double newAltitude = altitude - 0.3;
        
        Console.WriteLine(newAltitude);
    }
}
