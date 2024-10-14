using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string str1 = input.Split("-")[0];
        string str2 = input.Split("-")[1];
        int[] multipliers1 = {4, 3, 2, 7, 6, 5};
        int[] multipliers2 = {4, 3, 2, 1};
        int total = 0;
        for(int i = 0; i < str1.Length; i++)
        {
            int num = Int32.Parse(str1[i].ToString());
            total += num * multipliers1[i];
        }
        for(int i = 0; i < str2.Length; i++)
        {
            int num = Int32.Parse(str2[i].ToString());
            total += num * multipliers2[i];
        }
        if(total % 11 == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
