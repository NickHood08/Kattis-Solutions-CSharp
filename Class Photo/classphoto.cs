using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strWidth = Console.ReadLine();
        string strLength = Console.ReadLine();
        
        int width = int.Parse(strWidth);
        int length = int.Parse(strLength);
        int total = width * length;
        
        Console.WriteLine(total);
    }
}
