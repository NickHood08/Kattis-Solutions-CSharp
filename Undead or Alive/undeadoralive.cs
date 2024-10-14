using System;

public class Program
{
    public static void Main(string[] args)
    {
        string code = Console.ReadLine();
        if(code.Contains(":(") && !code.Contains(":)"))
        {
            Console.WriteLine("undead");
        }
        else if(!code.Contains(":(") && code.Contains(":)"))
        {
            Console.WriteLine("alive");
        }
        else if(code.Contains(":(") && code.Contains(":)"))
        {
            Console.WriteLine("double agent");
        }
        else
        {
            Console.WriteLine("machine");
        }
    }
}
