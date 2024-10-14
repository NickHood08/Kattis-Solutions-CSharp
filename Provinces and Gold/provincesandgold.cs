using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int gold = Int32.Parse(info.Split(" ")[0]);
        int silver = Int32.Parse(info.Split(" ")[1]);
        int copper = Int32.Parse(info.Split(" ")[2]);
        int total = (gold * 3) + (silver * 2) + copper;
        
        if(total >= 8)
        {
            Console.WriteLine("Province or Gold");
        }
        else if(total >= 6 && total <= 7)
        {
            Console.WriteLine("Duchy or Gold");
        }
        else if(total == 5)
        {
            Console.WriteLine("Duchy or Silver");
        }
        else if(total >= 3 && total <= 4)
        {
            Console.WriteLine("Estate or Silver");
        }
        else if(total == 2)
        {
            Console.WriteLine("Estate or Copper");
        }
        else
        {
            Console.WriteLine("Copper");
        }
    }
}
