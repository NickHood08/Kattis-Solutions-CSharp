using System;

public class Program
{
    public static void Main(string[] args)
    {
        int total = 0;
        int numInputs = Int32.Parse(Console.ReadLine());
        for(int i = 0; i < numInputs; i++)
        {
            int x = Int32.Parse(Console.ReadLine());
            int pow = x % 10;
            int num = x / 10;
            int temp = 1;
            for(int j = 0; j < pow; j++)
            {
                temp *= num;
            }
            total += temp;
        }
        Console.WriteLine(total);
    }
}
