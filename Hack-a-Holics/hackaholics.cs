using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumEvents = Console.ReadLine();
        string strMoneySpent = Console.ReadLine();
        string strAvgMoneyWon = Console.ReadLine();
        
        int numEvents = int.Parse(strNumEvents);
        int avgMoneyWon = int.Parse(strAvgMoneyWon);
        int cumulativeMoney = numEvents * avgMoneyWon;
        
        Console.WriteLine(cumulativeMoney);
    }
}
