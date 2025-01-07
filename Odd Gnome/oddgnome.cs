using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        string input = string.Empty;
        int king = 0;
        
        for(int i = 0; i < num; i++)
        {
            input = Console.ReadLine();
            int[] order = Array.ConvertAll(input.Split(" "), int.Parse);
            for(int j = 2; j < order.Length - 1; j++)
            {
                if(order[j - 1] + 1 != order[j])
                {
                    king = j;
                    break;
                }
            }
            Console.WriteLine(king);
        }
    }
}
