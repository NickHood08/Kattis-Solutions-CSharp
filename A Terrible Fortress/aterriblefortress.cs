using System;

public class Program
{
    public static void Main(string[] args)
    {
        string strNumInputs = Console.ReadLine();
        int numInputs = Int32.Parse(strNumInputs);
        string strNum = string.Empty;
        int num = 0;
        int total = 0;
        
        for(int i = 0; i < numInputs; i++)
        {
            strNum = Console.ReadLine();
            num = Int32.Parse(strNum);
            total += num;
        }
        
        Console.WriteLine(total);
    }
}
