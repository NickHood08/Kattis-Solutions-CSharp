using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        
        int num = int.Parse(strNum);
        int sum = 0;
        
        for(int i = 1; i <= num; i++)
        {
            sum += i;
            Console.WriteLine(sum);
        }
    }
}
