using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        int num = Int32.Parse(strNum);
        
        for(int i = 0; i < num; i++)
        {
            string estimate = Console.ReadLine();
            Console.WriteLine(estimate.Length);
        }
    }
}
