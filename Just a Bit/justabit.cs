using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char num = '$';
        int num0 = 0;
        int num1 = 0;
        
        for(int i = 0; i < input.Length; i++)
        {
            num = input[i];
            if(num == '0')
            {
                num0++;
            }
            else
            {
                num1++;
            }
        }
        
        Console.WriteLine(num0 + " " + num1);
    }
}
