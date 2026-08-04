using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        int num = int.Parse(input);
        
        while(num > 0)
        {
            Console.WriteLine(num);
            num -= 1;
        }
    }
}
