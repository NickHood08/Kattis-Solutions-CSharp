using System;

public class Program
{
    public static void Main(string[] args)
    {
        string input = string.Empty;
        
        bool flag = true;
        
        while(flag)
        {
            input = Console.ReadLine();
            
            if(input == "I quacked the code!")
            {
                flag = false;
            }
            else
            {
                if(input[input.Length - 1] == '?')
                {
                    Console.WriteLine("Quack!");
                }
                else
                {
                    Console.WriteLine("*Nod*");
                }
            }
        }
    }
}
