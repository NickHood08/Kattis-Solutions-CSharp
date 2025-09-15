using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string strKernel = string.Empty;
        
        int total = 0;
        
        for(int i = 0; i < input.Length; i++)
        {
            strKernel = input[i] + " ";
            
            if(strKernel == "1 ")
            {
                total += 1;
            }
        }
        
        Console.WriteLine(total);
    }
}
