using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int length = Int32.Parse(info.Split(" ")[0]);
        int h = Int32.Parse(info.Split(" ")[1]);
        int v = Int32.Parse(info.Split(" ")[2]);
        
        if(h > length / 2 && v > length / 2)
        {
            Console.WriteLine(h * v * 4);
        }
        else if(h > length / 2 && v < length / 2)
        {
            Console.WriteLine(h * (length - v) * 4);
        }
        else if(h < length / 2 && v > length / 2)
        {
            Console.WriteLine((length - h) * v * 4);
        }
        else
        {
            Console.WriteLine((length - h) * (length - v) * 4);
        }
    }
}
