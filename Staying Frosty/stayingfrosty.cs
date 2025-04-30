using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int w = Int32.Parse(input.Split(" ")[0]);
        int p = Int32.Parse(input.Split(" ")[1]);
        int numBlocksTravel = (180 * 2) * p;
        if(w <= numBlocksTravel)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
