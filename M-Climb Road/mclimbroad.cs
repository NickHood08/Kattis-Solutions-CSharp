using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strMiles = Console.ReadLine();
        string strFeet = Console.ReadLine();
        
        int miles = int.Parse(strMiles);
        int feet = int.Parse(strFeet);
        int milesToFeet = miles * 5280;
        int timesSquirted = milesToFeet / feet;
        
        Console.WriteLine(timesSquirted);
    }
}
