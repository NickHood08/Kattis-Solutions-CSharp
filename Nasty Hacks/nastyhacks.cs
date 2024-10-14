using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        int nonadvertisedRev = 0;
        int advertisedRev = 0;
        int advertisedCost = 0;
        for(int i = 0; i < n; i++)
        {
            string info = Console.ReadLine();
            nonadvertisedRev = Int32.Parse(info.Split(" ")[0]);
            advertisedRev = Int32.Parse(info.Split(" ")[1]);
            advertisedCost = Int32.Parse(info.Split(" ")[2]);
            if(nonadvertisedRev < (advertisedRev - advertisedCost))
            {
                Console.WriteLine("advertise");
            }
            else if(nonadvertisedRev == (advertisedRev - advertisedCost))
            {
                Console.WriteLine("does not matter");
            }
            else
            {
                Console.WriteLine("do not advertise");
            }
        }
    }
}
