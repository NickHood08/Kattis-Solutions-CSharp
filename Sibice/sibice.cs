using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int n = Int32.Parse(info.Split(" ")[0]);
        int w = Int32.Parse(info.Split(" ")[1]);
        int h = Int32.Parse(info.Split(" ")[2]);
        double total = Math.Sqrt(w * w + h * h);
        for(int i = 0; i < n; i++)
        {
            int match = Int32.Parse(Console.ReadLine());
            if(total >= match)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NE");
            }
        }
    }
}
