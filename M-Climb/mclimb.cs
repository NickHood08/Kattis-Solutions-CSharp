using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumRocks = Console.ReadLine();
        string strCost = Console.ReadLine();
        string strYear = Console.ReadLine();
        
        int numRocks = int.Parse(strNumRocks);
        int cost = int.Parse(strCost);
        int totalCost = numRocks * cost;
        
        Console.WriteLine(totalCost);
    }
}
