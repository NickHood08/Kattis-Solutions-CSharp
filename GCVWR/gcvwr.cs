using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int g = Int32.Parse(info.Split(" ")[0]);
        int t = Int32.Parse(info.Split(" ")[1]);
        int numItems = Int32.Parse(info.Split(" ")[2]);
        int towingCapacity = g - t;
        int itemsTotalWeight = 0;
        string itemsWeight = Console.ReadLine();
        for(int i = 0; i < numItems; i++)
        {
            itemsTotalWeight += Int32.Parse(itemsWeight.Split(" ")[i]);
        }
        Console.WriteLine((towingCapacity * .9) - itemsTotalWeight);
    }
}
