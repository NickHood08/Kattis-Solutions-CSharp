using System;

public class Program
{
    public static void Main(string[] args)
    {
        string bagInfo = Console.ReadLine();
        int numBags = Int32.Parse(bagInfo.Split(" ")[0]);
        int benniBag = Int32.Parse(bagInfo.Split(" ")[1]);
        string allBagInfo = Console.ReadLine();
        int[] allBagNums = Array.ConvertAll(allBagInfo.Split(" "), int.Parse);
        int bagPos = 0;
        for (int i = 0; i < allBagNums.Length; i++)
        {
            if(allBagNums[i] == benniBag)
            {
                bagPos = i;
            }
        }
        if(bagPos == 0)
        {
            Console.WriteLine("fyrst");
        }
        else if(bagPos == 1)
        {
            Console.WriteLine("naestfyrst");
        }
        else
        {
            Console.WriteLine((bagPos + 1) + " fyrst");
        }
    }
}
