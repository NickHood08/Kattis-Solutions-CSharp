using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strF = Console.ReadLine();
        
        int f = int.Parse(strF);
        int c =0;
        
        double notRoundedCelcius = (f - 32) * (5.0 / 9.0);
        
        c = (int) Math.Round(notRoundedCelcius, MidpointRounding.AwayFromZero);
        
        Console.WriteLine(c);
    }
}
