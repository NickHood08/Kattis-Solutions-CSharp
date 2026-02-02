using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        int[] percents = Array.ConvertAll(input.Split(" "), int.Parse);
        
        double final = (percents[0] * .25) + (percents[1] * .25) + (percents[2] * .5);
        
        if(final >= 90.0)
        {
            Console.WriteLine("A");
        }
        else if(final >= 80.0 && final < 90.0)
        {
            Console.WriteLine("B");
        }
        else if(final >= 70.0 && final < 80.0)
        {
            Console.WriteLine("C");
        }
        else if(final >= 60.0 && final < 70.0)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}
