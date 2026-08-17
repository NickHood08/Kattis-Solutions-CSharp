using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strDiameter = Console.ReadLine();
        
        double diameter = double.Parse(strDiameter);
        double radius = diameter / 2;
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3) / 2;
        double roundedVolume = Math.Round(volume, 9);
        
        Console.WriteLine(roundedVolume);
    }
}
