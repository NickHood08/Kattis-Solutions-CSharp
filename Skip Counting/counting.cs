using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strCount = Console.ReadLine();
        
        int count = int.Parse(strCount);
        int total = 0;
        
        for(int i = 0; i < 12; i++)
        {
            total += count;
            Console.WriteLine(total);
        }
    }
}
