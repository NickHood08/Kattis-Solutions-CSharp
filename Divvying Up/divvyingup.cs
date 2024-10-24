using System;

public class Program
{
    public static void Main(string[] args)
    {
        string n = Console.ReadLine();
        int numPrizes = Int32.Parse(n);
        string strPrizes = Console.ReadLine();
        int[] allPrizes = Array.ConvertAll(strPrizes.Split(" "), int.Parse);
        int totalPrizeMoney = 0;
        
        for(int i = 0; i < allPrizes.Length; i++)
        {
            totalPrizeMoney += allPrizes[i];
        }
        
        if(totalPrizeMoney % 3 == 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
