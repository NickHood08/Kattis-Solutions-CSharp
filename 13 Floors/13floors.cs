using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNum = Console.ReadLine();
        
        int num = int.Parse(strNum);
        
        if(num <= 12)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine(num + 1);
        }
    }
}
