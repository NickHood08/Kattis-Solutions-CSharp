using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        int totalLength = 0;
        for(int i = 0; i < n; i++)
        {
            totalLength += Int32.Parse(Console.ReadLine());
        }
        if(n % 2 == 0)
        {
            
        }
        Console.WriteLine(totalLength - (n - 1));
    }
}
