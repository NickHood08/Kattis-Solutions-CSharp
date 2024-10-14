using System;

public class Program
{
    public static void Main(string[] args)
    {
        string info = Console.ReadLine();
        int dice1 = Int32.Parse(info.Split(" ")[0]);
        int dice2 = Int32.Parse(info.Split(" ")[1]);
        if(dice1 == dice2)
        {
            Console.WriteLine(dice1 + 1);
        }
        else
        {
            for(int i = Math.Min(dice1, dice2) + 1; i <= Math.Max(dice1, dice2) + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
