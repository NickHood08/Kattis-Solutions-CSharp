using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] measurements = Array.ConvertAll(input.Split(" "), int.Parse);
        int area = measurements[0] * measurements[1] * measurements[2];
        
        if(area == measurements[3])
        {
            Console.WriteLine("COZY");
        }
        else if(area > measurements[3])
        {
            Console.WriteLine("SO MUCH SPACE");
        }
        else
        {
            Console.WriteLine("TOO TIGHT");
        }
    }
}
