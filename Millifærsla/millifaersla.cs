using System;

public class Program
{
    public static void Main(string[] args)
    {
        int monneiFee = Int32.Parse(Console.ReadLine());
        int fjeeFee = Int32.Parse(Console.ReadLine());
        int dolladollaFee = Int32.Parse(Console.ReadLine());
        int smallestFee = Math.Min(monneiFee, Math.Min(fjeeFee, dolladollaFee));
        if(smallestFee == monneiFee)
        {
            Console.WriteLine("Monnei");
        }
        else if(smallestFee == fjeeFee)
        {
            Console.WriteLine("Fjee");
        }
        else
        {
            Console.WriteLine("Dolladollabilljoll");
        }
    }
}
