using System;

public class Program
{
    public static void Main(string[] args)
    {
        int t = Int32.Parse(Console.ReadLine());
        int total = 1;
        for (int i = 0; i < t; i++)
        {
            int num = Int32.Parse(Console.ReadLine());
            for(int j = 1; j <= num; j++)
            {
                total *= j;
            }
            string strTotal = total.ToString();
            Console.WriteLine(strTotal.Substring((strTotal.Length - 1)));
            total = 1;
        }
    }
}
