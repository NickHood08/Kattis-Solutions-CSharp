using System;

public class Program
{
    public static void Main(string[] args)
    {
        string rookPos = Console.ReadLine();
        string pawnPos = Console.ReadLine();
        int rookPos1 = Int32.Parse(rookPos.Split(" ")[0]);
        int rookPos2 = Int32.Parse(rookPos.Split(" ")[1]);
        int pawnPos1 = Int32.Parse(pawnPos.Split(" ")[0]);
        int pawnPos2 = Int32.Parse(pawnPos.Split(" ")[1]);
        
        if(rookPos1 != pawnPos1 && rookPos2 != pawnPos2)
        {
            Console.WriteLine("2");
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}
