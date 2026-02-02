using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strN = Console.ReadLine();
        string strH = Console.ReadLine();
        string strX = Console.ReadLine();
        string strM = Console.ReadLine();
        string strY = Console.ReadLine();
        
        double n = Double.Parse(strN);
        double h = Double.Parse(strH);
        double x = Double.Parse(strX);
        double m = Double.Parse(strM);
        double y = Double.Parse(strY);
        double i = 0.0;
        
        
        i = (y / m) / ((x / n) / h);
        
        Console.WriteLine(i);
    }
}
