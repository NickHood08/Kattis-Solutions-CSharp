using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strBudget = Console.ReadLine();
        string strSeedingCost = Console.ReadLine();
        string strEquatorialCost = Console.ReadLine();
        string strSpaceCost = Console.ReadLine();
        
        int budget = int.Parse(strBudget);
        int seedingCost = int.Parse(strSeedingCost);
        int equatorialCost = int.Parse(strEquatorialCost);
        int spaceCost = int.Parse(strSpaceCost);
        
        int total = budget - (seedingCost + equatorialCost + spaceCost);
        
        if(total >= 0)
        {
            Console.WriteLine("Budget is sufficient.");
        }
        else
        {
            Console.WriteLine("Budget is insufficient.");
        }
    }
}
