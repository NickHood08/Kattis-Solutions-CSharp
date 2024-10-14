using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int numClassrooms = Int32.Parse(info.Split(" ")[0]);
        int numBottles = Int32.Parse(info.Split(" ")[1]);
        int totalBottlesNeeded = 0;
        for(int i = 0; i < numClassrooms; i++)
        {
            totalBottlesNeeded += Int32.Parse(Console.ReadLine());
        }
        if(totalBottlesNeeded > numBottles)
        {
            Console.WriteLine("Neibb");
        }
        else
        {
            Console.WriteLine("Jebb");
        }
    }
}
