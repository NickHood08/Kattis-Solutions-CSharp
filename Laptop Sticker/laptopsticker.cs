using System;

public class Program
{
    public static void Main(string[] args)
    {
        string inputs = Console.ReadLine();
        int wc = Int32.Parse(inputs.Split(" ")[0]);
        int hc = Int32.Parse(inputs.Split(" ")[1]);
        int ws = Int32.Parse(inputs.Split(" ")[2]);
        int hs = Int32.Parse(inputs.Split(" ")[3]);
        
        if(wc - ws > 1 && hc - hs > 1)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
